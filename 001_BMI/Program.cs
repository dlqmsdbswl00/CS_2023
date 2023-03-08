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
            Console.WriteLine("BMI + " + bmi);
        }
    }
}
