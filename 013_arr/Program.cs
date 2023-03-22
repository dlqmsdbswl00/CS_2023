using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_arr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];  //10개의 정수를 읽어서 배열에 저장

            for (int i = 0; i < 10; i++)
                a[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();

            foreach (var x in a)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}