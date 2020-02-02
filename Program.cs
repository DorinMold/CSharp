using System;
using System.Text;

namespace Calculator
{
    class Program
    {
        static string calculType;
        static string[] calculations = { "1", "2", "3", "4", "5" };
        static bool answerCorr;
        static int num1;
        static int num2;
        static int result;
        static string repeat = new string("");
        static string[] YesOrNo = { "Y", "N" };
        static int num5 = 350;
        static float num6 = 4800.356F;
        static float num7;
       

        static void Main(string[] args)
        {
        int incercare = 30;
        Beginning:
            Console.WriteLine("Please choose the number for what type of calculation would you like to be performed:");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Multiplication");
            Console.WriteLine("3. Subtraction");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Power");
            Console.WriteLine("---------------");

            checkSelection();

            Console.WriteLine(incercare);
            Console.WriteLine("Write the first number");

            do
            {
                try
                {
                    num1 = int.Parse(Console.ReadLine());
                    answerCorr = true;
                } catch (FormatException e)
                {
                    answerCorr = false;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You didn't input a number. Please do so");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            } while (answerCorr == false);
            Console.WriteLine("Write the second number");

            do
            {
                try
                {
                    num2 = int.Parse(Console.ReadLine());
                    answerCorr = true;
                }
                catch (FormatException e)
                {
                    answerCorr = false;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You didn't input a number. Please do so");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            } while (answerCorr == false);

            switch (calculType)
            {
                case "1":
                    result = num1 + num2;
                    break;
                case "2":
                    result = num1 * num2;
                    break;
                case "3":
                    result = num1 - num2;
                    break;
                case "4":
                    result = num1 / num2;
                    break;
                case "5":
                    RidicareLaPutere RidPut = new RidicareLaPutere(num1, num2);
                    result = RidPut.rezultat();
                    break;
            }

            Console.WriteLine("Your result is {0}", result);
            num7 = num5 + num6;
            Console.WriteLine(num7);

            do
            {
                // if (repeat.Length > 0 && (!repeat.Equals("Y") || !repeat.Equals("N"))) Console.WriteLine("Your selection was not correct");
                if (!string.IsNullOrEmpty(repeat) && (!repeat.Equals("Y") || !repeat.Equals("N"))) Console.WriteLine("Your selection was not correct");

                Console.WriteLine("Do you want to try again? Y / N");
                repeat = Console.ReadLine().ToUpper();
            } while (Array.IndexOf(YesOrNo, repeat) == -1);
            if (repeat == "Y")
            {
                repeat = "";
                goto Beginning;
            }

            Environment.Exit(0);
        }

        private static void checkSelection()
        {
            do
            {
                calculType = Console.ReadLine();
                if (Array.IndexOf(calculations, calculType) == -1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You selection is wrong. Please try again");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    answerCorr = false;
                }
                else { answerCorr = true; }
            } while (answerCorr == false);
        }
    }
}
