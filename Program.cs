namespace Assignments_3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year to check if it's a leap year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeap = IfYearIsLeap(year);
            Console.WriteLine($"Is {year} a leap year? {isLeap}");
        }

        static bool IfYearIsLeap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
