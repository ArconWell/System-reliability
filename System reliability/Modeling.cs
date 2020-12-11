using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_reliability
{
    class Modeling
    {
        Random random = new Random();
        //интенсивность отказов
        const double failureRate = 0.04;
        //интевность восстановления
        const double recoveryRate = 0.5;
        //необходимое количество отказавших элементов для отказа системы
        const int necessaryFailureElementsCount = 3;

        public bool[] CalculateOnePass(double[] timePassed, params bool[] elementsStates)
        {
            //массив состояний элементов после прохода (на один меньше, так как значение системы будет рассчитываться позже)
            bool[] outElementsStates = new bool[elementsStates.Length - 1];
            //проход по всем элементам
            for (int i = 0; i < elementsStates.Length - 1; i++)
            {
                double randomValue = random.NextDouble();
                //если элемент работает
                if (elementsStates[i])
                {
                    double failureProbability = 1 - Math.Exp(-failureRate * timePassed[i]);
                    //если элемент отказывает
                    if (randomValue <= failureProbability)
                    {
                        //изменить состояние элемента на "отказ"
                        outElementsStates[i] = false;
                    }
                    else
                    {
                        outElementsStates[i] = true;
                    }
                }
                //если элемент отказал
                else
                {
                    double recoveryProbability = 1 - Math.Exp(-recoveryRate * timePassed[i]);
                    //если элемент восстанавливается
                    if (randomValue <= recoveryProbability)
                    {
                        //изменить состояние элемента на "работает"
                        outElementsStates[i] = true;
                    }
                    else
                    {
                        outElementsStates[i] = false;
                    }
                }
            }
            //находим количество отказавших элементов
            int failureElementsCount = outElementsStates.Count(x => !x);
            //определяем и записываем состояние системы
            outElementsStates = outElementsStates.Append(!(failureElementsCount >= necessaryFailureElementsCount)).ToArray();
            return outElementsStates;
        }
    }
}
