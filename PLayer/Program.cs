using System;

namespace PLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, bd, studyyr;
            Console.WriteLine("\nName: ");
            name = Console.ReadLine();

            Console.WriteLine("\n Date of Birth: ");
            bd = Console.ReadLine();

            Console.WriteLine("\nStudy Year: ");
            studyyr = Console.ReadLine();

            Console.WriteLine("Yout information is", name, bd, studyyr);

            Console.WriteLine("\nThe total number of females in their second year is...", StudentList.Count);

            Console.ReadKey();

        }
    }
}
