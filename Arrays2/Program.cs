using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            string proceed = "y";
            string changeArray;
            int index, newIndex;
            int[] numbers = { 2, 8, 0, 24, 51 };

            while(proceed == "y")
            {
                index = userNumber("Enter an index of the array: ");
                if (index < 0 || index > (numbers.Length - 1))
                {
                    index = userNumber("Invalid index!  Please enter an index between 0 and " + (numbers.Length - 1));
                }

                changeArray = Continue("The value at index " + index + " is " + numbers[index] + ". Do you want to change it? (y/n)").ToLower();
                if (changeArray == "y")
                {
                   Console.WriteLine("Enter the new value at index " + index + ": ");
                    newIndex = int.Parse(Console.ReadLine());
                    numbers[index] = newIndex;
                }

                proceed = Continue("Do you want to enter another index? (y/n)").ToLower();

                //while(proceed != "y" || proceed != "n")
                //{
                //    Console.WriteLine("Invalid input!  Please enter (y/n)");
                //    proceed = Console.ReadLine();
                //}
                if (proceed == "n")
                {
                    Console.WriteLine("Good bye!");
                }
             
            }

            Console.ReadKey();
        }

        public static string Continue(string message)
        {
            Console.WriteLine(message);
            string proceed = Console.ReadLine();
            return proceed;
        }

        public static int userNumber(string message)
        {
            Console.WriteLine(message);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
