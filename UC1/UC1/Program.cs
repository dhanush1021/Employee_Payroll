using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int val = rnd.Next(3);
            switch (val)
            {
                case 0:
                    Console.WriteLine("Absent");
                    break;
                case 1:
                    Console.WriteLine("Part Time");
                    break;
                case 2:
                    Console.WriteLine("Full Time");
                    break;
            }
            Console.ReadKey();
        }
    }
}
