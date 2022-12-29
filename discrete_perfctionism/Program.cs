using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discerete_perfctionism
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("start number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("end number");
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int sum = 0;
                for (int x = 1; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        sum += x;

                    }
                }
                if (sum == i)
                {
                    Console.WriteLine("'{0}'is perfect", i);

                }

                Console.ReadKey();
            }



        }
    }
}
