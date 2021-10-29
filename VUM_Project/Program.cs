using System;

namespace VUM_Project
{
    class Program
    {
        static int NumberTyping()
        {
            Console.WriteLine("Enter a number");
            int number;

            while (int.TryParse(Console.ReadLine(), out number) == false) ;
            return number;

        }
        static decimal TempConvert(int tempunit, int starttemp)
        {
            decimal result;
            if (tempunit == 1)
            {
                result = ((decimal)starttemp*9/5)+32;
            }
            else
            {
                result = ((decimal)starttemp -32)*5/9;
            }
            Console.WriteLine(result);
            return result;
        }
        static decimal ConsumptConvert(int tempconsumpt, int startconsumpt)
        {
            decimal result;
            if (tempconsumpt == 1)
            {
                result = ((decimal)235.215 * startconsumpt);
            }
            else
            {
                result = (decimal)235.215/startconsumpt;
            }
            Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Console.WindowHeight = 50;
            Console.WindowWidth = 150;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu :\n"
                                 + "Section 1 : \n"
                                 + "    - Temperature [TYPE 1]\n"
                                 + "    - Fuel [TYPE 2]\n"
                                 + "!!WORK IN PROGRESS!!Section 2 :\n"
                                 + "!!WORK IN PROGRESS!!    - Bigger [TYPE 3]\n"
                                 + "!!WORK IN PROGRESS!!    - Factorial [TYPE 4]\n"
                                 + "!!WORK IN PROGRESS!!Section 3\n"
                                 + "!!WORK IN PROGRESS!!    - MinMaxSumAverage [TYPE 5]\n"
                                 + "!!WORK IN PROGRESS!!    - Array cleaner [TYPE 6]\n"
                                 + "!!WORK IN PROGRESS!!Section 4\n"
                                 + "!!WORK IN PROGRESS!!    - Email check [TYPE 7]\n"
                                 + "!!WORK IN PROGRESS!!    - UPPERlower [TYPE 8]\n"
                                 + "!!WORK IN PROGRESS!!To leave the menu [TYPE 0]\n"
                                 + "!!WORK IN PROGRESS!!Please pick what you want to try.");
                int exo = NumberTyping();
                Console.WriteLine(" ");
                if (exo != 0)
                {
                    switch (exo)
                    {
#region
                        case 1:
                            Console.WriteLine("What unit are you using ?\n"
                                 + "  - Celsius [TYPE 1]\n"
                                 + "  - Fahrenheit [TYPE 2]\n");
                            int tempunit = NumberTyping();
                            while (tempunit != 1 & tempunit != 2)
                            {
                                Console.WriteLine("Please type a correct value");
                                tempunit = NumberTyping();
                            }
                            string unit;
                            string opposite;
                            if (tempunit == 1) { unit = "Celsius"; opposite = "Fahrenheit"; }
                            else  { unit = "Fahrenheit"; opposite = "Celsius"; }
                            Console.WriteLine("Correct value !\n"
                                             +"Enter the starting value please.");
                            int starttemp = NumberTyping();
                            Console.WriteLine(starttemp + " " + unit + " degrees are equal to " + TempConvert(tempunit, starttemp) + " " + opposite + " degrees.");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("What system are you using ?\n"
                                 + "  - L/100 [TYPE 1]\n"
                                 + "  - MPG [TYPE 2]\n");
                            int tempconsumpt = NumberTyping();
                            while (tempconsumpt != 1 & tempconsumpt != 2)
                            {
                                Console.WriteLine("Please type a correct value");
                                tempconsumpt = NumberTyping();
                            }
                            string system;
                            string othersystem;
                            if (tempconsumpt == 1) { system = "L/100"; othersystem = "MPG"; }
                            else { system = "MPG"; othersystem = "L/100"; }
                            Console.WriteLine("Correct value !\n"
                                             + "Enter the starting value please.");
                            int startconsumpt = NumberTyping();
                            Console.WriteLine(startconsumpt + " " + system + " are equal to " + ConsumptConvert(tempconsumpt, startconsumpt) + " " + othersystem + " .");
                            Console.ReadKey();

                            break;
                        #endregion
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        default: Console.WriteLine("The exemple does not exist !");
                            break;
                        
                    }
                    break;
                }
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
