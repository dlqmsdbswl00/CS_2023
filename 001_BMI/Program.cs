using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("키 : ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("몸무게 : ");
            double weight = double.Parse(Console.ReadLine());

            double bmi = weight/(height/100 * height/100);
            //Console.WriteLine("BMI = {0, 20:F2}", bmi);

            Console.WriteLine("BMI = {0:F2}", bmi);

            // 비만 판정
            if (bmi < 20)
            {
                Console.WriteLine("저체중");
            }
            else if (20 <= bmi && bmi < 25)
            {
                Console.WriteLine("정상체중");
            }
            else if (25 <= bmi && bmi < 30)
            {
                Console.WriteLine("경도비만");
            }
            else if (30 <= bmi && bmi < 40)
            {
                Console.WriteLine("비만");
            }
            else
                Console.WriteLine("고도비만");
        }
    }
}
