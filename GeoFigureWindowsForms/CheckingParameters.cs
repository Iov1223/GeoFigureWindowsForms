using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFigureWindowsForms
{
    class CheckingParameters
    {
        public decimal value;
        public void CheckParameters(string Parameter)
        {
            if (Decimal.TryParse(Parameter, out var res))
            {
                value = res;
                if (value <= 0)
                {
                    throw new Exception("Значение не может быть отрицательным или равняться нулю.");
                }
            }
            else
            {
                throw new Exception("Ввод должен содержать толко числа.");
            }
        }
        public decimal ReturnValue()
        {
            return value;
        }
        public void CheckTriangle(decimal AB, decimal BC, decimal AC)
        {
            if (BC + AC <= AB)
            {
                throw new Exception("Сумма первой и второй сторон не может быть меньше основания или равно ему!");
            }
            else
            {
                double P = ((double)AB + (double)AC + (double)BC) / 2;
                double isCorrect = Math.Sqrt((double)(P * (P - (double)AB) * (P - (double)BC) * (P - (double)AC)));
                if (isCorrect <= 0)
                {
                    throw new Exception("Такого треугольника не существует!");
                }
            }
        }
    }
}
