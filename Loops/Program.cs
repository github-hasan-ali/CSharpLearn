using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            string[] students =new string[3] {"hasan","ali","kart"};
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();

        }

    }
}
