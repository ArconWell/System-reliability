using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace System_reliability
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool[] currentSeriesStates;//текущие состояния элементов
        const double timeUnit = 0.5;//единица времени. Влияет на скорость таймер. Кореллируется секунды-часы
        double timePassed = 0;//общее прошедшее время
        double[] timeSinceLastFailure;//время, прошедшее с момента последнего отказа у каждого отдельного элемента
        double[] k;
        Modeling modeling = new Modeling();
        int currentCountOfExperiments = 0;//текущее число циклов
        int countOfFreeAndMoreFail = 0;//текущее число состояний, когда отказало более 3 эл-ов

        private void ShowModelingResultsGraphic()
        {
            InitializeSeries();
            ConfigureScrollBar();
            timer1.Start();
        }

        private void ClearChart()
        {
            timePassed = 0;
            for (int i = 0; i < chartModeling.Series.Count; i++)
            {
                chartModeling.Series[i].Points.Clear();
            }
        }

        private void ConfigureScrollBar()
        {
            const int Scroll = 20;//количество точек до скрола
            chartModeling.ChartAreas[0].AxisX.Interval = 1; //интервал делений X
            chartModeling.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;//скрол над цифрами
            chartModeling.ChartAreas[0].AxisX.ScaleView.Size = Scroll;//размер скрола
            chartModeling.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;//только полоса
            chartModeling.ChartAreas[0].AxisX.ScrollBar.BackColor = Color.DarkGray; //цвета
            chartModeling.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.DimGray; //цвета
        }

        private void InitializeSeries()
        {
            currentSeriesStates = new bool[chartModeling.Series.Count];
            k = new double[chartModeling.Series.Count];
            timeSinceLastFailure = new double[chartModeling.Series.Count - 1];
            //инициализирую массив текущих состояний элементов начальными состояниями и добавляю начальные точки на chart
            //+ заполняю коэффициенты + заполняю время, прошедшее после последнего отказа
            for (int i = 0; i < currentSeriesStates.Length; i++)
            {
                currentSeriesStates[i] = true;
                chartModeling.Series[i].Points.AddXY(0, i + 1);
                k[i] = 0;
                if (i != currentSeriesStates.Length - 1)
                    timeSinceLastFailure[i] = 0;
            }
        }

        private void UpdateSeries(Object myObject, EventArgs myEventArgs)
        {
            currentCountOfExperiments++;
            timePassed += timeUnit;
            currentSeriesStates = modeling.CalculateOnePass(timeSinceLastFailure, currentSeriesStates);
            OutputOneState(currentSeriesStates, currentCountOfExperiments);
            CheckOfFail(currentSeriesStates);
            lbRezult.Text = $"Число случаев, соответствующих отказам более 3 элементов: {countOfFreeAndMoreFail.ToString()}";
            //обновление графиков(добавление новой точки) в зависимости от состояний элементов
            for (int i = 0; i < chartModeling.Series.Count; i++)
            {
                if (i != chartModeling.Series.Count - 1)
                    timeSinceLastFailure[i] += timeUnit;
                if (!currentSeriesStates[i])
                {
                    if (k[i] == 0 && i != chartModeling.Series.Count - 1)
                    {
                        timeSinceLastFailure[i] = 0;
                    }
                    k[i] = 0.5;
                }
                else
                {
                    if (k[i] == 0.5 && i != chartModeling.Series.Count - 1)
                    {
                        timeSinceLastFailure[i] = 0;
                    }
                    k[i] = 0;
                }
                UpdateOneSeries(i, timePassed, (double)i + 1 - k[i]);
            }

            ////отображение скроллбара
            if (timePassed / chartModeling.ChartAreas[0].AxisX.ScaleView.Size > (int)timePassed / chartModeling.ChartAreas[0].AxisX.ScaleView.Size)//начать скролл при выходе за границу
                chartModeling.ChartAreas[0].AxisX.ScaleView.Scroll((int)(timePassed / chartModeling.ChartAreas[0].AxisX.ScaleView.Size) * chartModeling.ChartAreas[0].AxisX.ScaleView.Size);//скролл
        }

        private void OutputOneState(bool[] currentState, int rowIndex)
        {
            dgStates.Rows.Add();
            dgStates[0, rowIndex - 1].Value = timePassed;
            for (int j = 1; j <= currentState.Length; j++)
            {
                dgStates[j, rowIndex - 1].Value = currentState[j - 1];
            }
            if (!currentState[currentState.Length - 1])
            {
                DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                dataGridViewCellStyle.BackColor = Color.Yellow;
                dgStates.Rows[rowIndex - 1].DefaultCellStyle = dataGridViewCellStyle;
            }
        }

        private void UpdateOneSeries(int seriesNumber, double x, double y)
        {
            Series series = chartModeling.Series[seriesNumber];
            series.Points.AddXY(x, y);
        }

        //подсчёт случаев, когда отказало более 3 эл-ов
        private void CheckOfFail(bool[] currentState)
        {
            int count = 0;
            for (int i = 0; i < currentState.Length; i++)
            {
                if (!currentState[i])
                    count++;
            }
            if (count >= 3)
                countOfFreeAndMoreFail++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelInfo.Text = $"Каждые {timeUnit} секунды моделирования равны {timeUnit} часам реального времени.";
            timer1.Interval = (int)(timeUnit * 1000);
            timer1.Tick += new EventHandler(UpdateSeries);
            InitializeSeries();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            countOfFreeAndMoreFail = 0;
            currentCountOfExperiments = 0;
            dgStates.Rows.Clear();
            ClearChart();
            ShowModelingResultsGraphic();
            buttonPauseContinue.Text = "Пауза";
            buttonPauseContinue.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            buttonPauseContinue.Enabled = false;
        }


        private void buttonPauseContinue_Click(object sender, EventArgs e)
        {
            if (buttonPauseContinue.Text == "Пауза")
            {
                buttonPauseContinue.Text = "Продолжить";
                timer1.Enabled = false;
            }
            else
            {
                buttonPauseContinue.Text = "Пауза";
                timer1.Enabled = true;
            }
        }
    }
}
