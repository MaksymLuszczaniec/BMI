using System;
using System.Text;

namespace ConsoleCalculatorBmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calulator BMI");
            Console.WriteLine("enter your weight (w kg):");

            string massString = Console.ReadLine();
            double mass = double.Parse(massString);

            Console.WriteLine("enter your height (in meters):");

            string heightString = Console.ReadLine();
            double height = double.Parse(heightString);

            double bmi = mass / (height * height);

            Console.WriteLine("your bmi result; " + bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("score is underweight bmi score");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Your weight is normal");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("your weight is overweight");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.WriteLine("Your weight is obesity");
            }
            else
            {
                Console.WriteLine("Your weight is morbidly obese");
            }
        }
    }
}