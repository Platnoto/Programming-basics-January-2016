using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            for (int i = 1; i <= n - 2; i++)
            {
                string rowStar = '*' + new string  (' ',n - 2) + '*';
                Console.WriteLine(rowStar);
                    
            }
            Console.WriteLine(new string ('*',n));
        }
    }
}
