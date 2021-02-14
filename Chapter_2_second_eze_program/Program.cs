using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2_second_eze_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // здесь объявляется переменная
            int y; // здесь объявляется еще одна переменная
            x = 100; // здесь переменной х присваивается значение 100
            Console.WriteLine("х содержит " + x);
            y = x / 2;
            Console.Write("у содержит x / 2: ");
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}

