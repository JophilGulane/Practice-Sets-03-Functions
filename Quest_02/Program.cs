using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quest_02
{
    internal class Program
    {
        //Create a function that determines whether a given year is a leap year or not.
        //A leap year is a year that is evenly divisible by 4, 
        //except for years that are both divisible by 100 and not divisible by 400.
        static void Main(string[] args)
        {

            Console.Write("Enter a Year: ");
            int year = int.Parse(Console.ReadLine());

            if (isLeapYear(year))
            {
                Console.WriteLine("is a Leap Year!");
            }
            else
            {
                Console.WriteLine("is NOT a Leap Year!");
            }
        }

        static bool isLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
