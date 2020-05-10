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
            var result = Add2(20);
            Console.WriteLine("Toplam= {0}", result);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1,int number2=42)
        {
            var result = number1 + number2;
            return result;

        }
    }
}
