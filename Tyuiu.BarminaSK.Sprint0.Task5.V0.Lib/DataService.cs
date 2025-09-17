using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BarminaSK.Sprint0.Task5.V0.Lib
{

    public class DataService
    {
        //Пример линейной структуры
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                //Пример чисто для демонстрации
                //В обычных программах используется Exception
                Console.WriteLine("Переменная b = {0} на ноль делить нельзя ", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}
