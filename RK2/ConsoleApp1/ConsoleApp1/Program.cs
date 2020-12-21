using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate bool Delegate1(double p1, float p2, int p3);

    class Program
    {
        static bool AllPositive_YorN(double p1, float p2, int p3)//  проверка на подложительность всех чисел
        {
            if (p1 > 0 && p2 > 0 && p3 > 0)
                return true;
            else
                return false;
        }
        
        static bool CompositionPos_YorN(double p1, float p2, int p3)// проверка на положительность произведения
        {
            if (p1 * p2 * p3 > 0)
                return true;
            else
                return false; 
        }

        static void PosFun(string str, double p1, float p2, int p3, Delegate1 Param)
        {
            bool result = Param(p1, p2, p3);
            Console.WriteLine(str + result.ToString());
        }

        static void Main(string[] args)
        {
            double p1 = -12.44;
            float p2 = -14.3f;
            int p3 = 200;
            Console.WriteLine($"Допустим: p1= {p1} p2= {p2} p3= {p3}");
            PosFun("Все ли числа положительны? ", p1, p2, p3, AllPositive_YorN);
            PosFun("Положительно ли произведение? ", p1, p2, p3, CompositionPos_YorN);

           Delegate1 dg1 = (double x, float y, int z) =>// проверим на положительность сумму
            {
                if (x + y + z > 0)
                    return true;
                else return false;
            };
            bool test = dg1(1.1, -12, -12);
            
           PosFun("Пример с лямбда-выражения в виде переменной: ", p1, p2, p3, dg1);
            Console.WriteLine($"test= {test}");

        }
    }
}
