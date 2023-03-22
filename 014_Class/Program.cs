using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            for(int i  = 0; i < 10; i++)
                Console.WriteLine(r.Next(10));
            Console.WriteLine();

            //10명의 성적을 저장하는 배열 score, 랜덤으로 정수 생성 후 저장
            int[] score = new int[10];

            for (int i = 0; i < 10; i++)
                score[i] = r.Next(101);

            foreach(int S in score)
                Console.Write("{0}점 ", S);
        }
    }
}
