using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_for_1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //43장. 1~100의 합
            int sum = 0;
            for (int i = 1; i <= 100; i++)
                sum += i;
            Console.WriteLine("1~100의 합 : {0}", sum);


            //1~100까지 홀수의 합
            sum = 0;
            for(int i = 1; i <= 100; i++)
                if (i % 2 == 0)
                    sum += i;
            Console.WriteLine("1~100까지 홀수의 합 : {0}", sum);
            

            //1~100까지 역수의 합
            double rsum = 0;
            for (int i = 1; i <= 100; i++)
                rsum += 1.0 / i;
            Console.WriteLine("1~100까지 역수의 합 : {0:F2}\n", rsum);


            //45장. 구구단
            Console.Write("구구단의 단을 입력 : ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0}x{1}={2}", x, i,x*i);
            }
            Console.WriteLine("");


            //47장. n의 m승 구하기
            Console.Write("n 입력 : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m 입력 : ");
            int m = int.Parse(Console.ReadLine());
            int exp = 1;
            for (int i = 1; i <= m; i++)
                exp *= n;
            Console.WriteLine(exp);
            Console.WriteLine("");


            // 53장. 팩토리얼 (k! = 1*2*3*4*...k)
            Console.Write("구하고자 하는 팩토리얼 입력 : ");
            int k = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1;i <= k; i++)
                fact *= i;
            Console.WriteLine("{0}의 팩토리얼 = {1}", k, fact);

        }
    }
}
