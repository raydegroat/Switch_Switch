using System;

namespace Switch_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput; // Variable for containing user input

            Console.WriteLine("Enter an integer between 0 and 10 "); //Ask user for input

            userInput = Convert.ToInt32(Console.ReadLine()); //Get user input & convert to int

            if ((userInput == 9) || (userInput == 10))
            {

            }

            switch (userInput)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Fail");
                    break;
                case 1:
                    Console.WriteLine("Fail");
                    break;
                case 2:
                    Console.WriteLine("Fail");
                    break;
                case 3:
                case num1
                default:
                    break;
            }





        }
    }
}
