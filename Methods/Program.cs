using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 33;
            var result = Add2(ref number1,number2);
            Console.WriteLine(number1);
            Console.WriteLine("Toplam= {0}", result);
            Console.WriteLine(Multiply(2,88));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(ref int number1,int number2=42)
        {
            number1 = 33;
            var result = number1 + number2;
            return result;

        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
