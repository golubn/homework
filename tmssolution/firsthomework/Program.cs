using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the number of the day of the week:");
                string number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        Console.WriteLine("Monday\n");
                        break;
                    case "2":
                        Console.WriteLine("Tuesday\n");
                        break;
                    case "3":
                        Console.WriteLine("Wednesday\n");
                        break;
                    case "4":
                        Console.WriteLine("Thursday\n");
                        break;
                    case "5":
                        Console.WriteLine("Friday\n");
                        break;
                    case "6":
                        Console.WriteLine("Saturday\n");
                        break;
                    case "7":
                        Console.WriteLine("Sunday\n");
                        break;
                    default:
                        Console.WriteLine("You entered an incorrect number!!!\n");
                        break;

                }

            }
        }
    }
}
