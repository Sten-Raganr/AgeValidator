using System;

namespace AgeValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year of Birth:");
            string YearInput = Console.ReadLine();
            if (YearValidator(YearInput))
            {
                AgeCalc(YearInput);
            }            
        }
        public static bool YearValidator(string YearInput)
        {

            if (YearInput.Length == 4)
            {
                try
                {
                    Int32.Parse(YearInput);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format = {e}");
                    return false;                   
                }
            }
            else
            {
                Console.WriteLine("Wrong Format!");
                return false;
            } 
        }public static void AgeCalc(string YearInput)
        {
            int year = Int32.Parse(YearInput);
            DateTime now = DateTime.Now;
            string currentYear = now.Year.ToString();
            int yearNow = Int32.Parse(currentYear);
            int age = yearNow - year;
            Console.WriteLine($"You are {age} years old.");
        }
    }
}
