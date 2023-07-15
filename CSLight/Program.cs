using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] petrovich = new int[3];
            int[] ivanovich = new int[5];
            int[] sidorovich;

            petrovich[0] = 5;
            petrovich[1] = 3;

            sidorovich = petrovich;

            sidorovich[2] = 7;
            sidorovich[0] = 10;

            Console.WriteLine(ivanovich[0]);
            Console.WriteLine(ivanovich[1]);

            petrovich = new int[10];

        }
    }
}