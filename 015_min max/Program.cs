using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//외워

namespace _015_min_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] a = new int[10];

            int sum = 0;

            for (int i = 0; i < 10; i++)
                a[i] = r.Next(101);
            int min = a[0];
            int max = a[0];

            for (int i = 0; i < 10; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
                sum += a[i];
            }
            Console.WriteLine("최대값 : {0} 최소값 : {1} 평균 : {2}", max, min, sum/10.0);
        }
    }
}
