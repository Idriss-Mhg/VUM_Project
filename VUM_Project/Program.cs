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
        static int[] CleanArray(int[] array)
        {
            int[] cleanarray = new int[array.Length];
            int i = 0;
            bool truth = false;
            foreach (int number in array)
            {
                foreach (int subnumber in cleanarray)
                {
                    if (subnumber == number)
                    {
                        truth = true;
                    }
                }
                if (truth == false)
                {
                    cleanarray[i] = number;
                }
                i++;
                truth = false;
            }
            return (cleanarray);
        }
        static bool EmailCheck(string email)
        {

            bool check = true;

            if (email.IndexOf("@") != email.LastIndexOf("@")) check = false;
            if (email.EndsWith(".")) check = false;
            if (email.Contains("..")) check = false;
            if (email.Contains("#") | email.Contains("*") | email.Contains("+") | email.Contains("&") | email.Contains("'") | email.Contains("!") | email.Contains("%") | email.Contains("?") | email.Contains("{") | email.Contains("}") | email.Contains("^") | email.Contains("\"")) check = false;
            if (email.IndexOf("@") == -1) check = false;
            if (email.IndexOf("@") > email.LastIndexOf(".")) check = false;
                return check;
        }
        static string WordUpper(string word)
        {
            string uppedword = word.ToUpper();

            return uppedword;
        }
        static string SentenceUpper(string sentence)
        {
            string [] words = sentence.Split();

            string uppedsentence ="";

            foreach( string word in words)
            {
                uppedsentence += WordUpper(word) + " ";
            }
            uppedsentence.Trim();
            return uppedsentence;
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
                                 + "Section 2 :\n"
                                 + "    - Biggest [TYPE 3]\n"
                                 + "    - Factorial [TYPE 4]\n"
                                 + "Section 3\n"
                                 + "    - MinMaxSumAverage [TYPE 5]\n"
                                 + "    - Array cleaner [TYPE 6]\n"
                                 + "Section 4\n"
                                 + "    - Email check [TYPE 7]\n"
                                 + "    - UPPERlower [TYPE 8]\n"
                                 + "To leave the menu [TYPE 0]\n"
                                 + "Please pick what you want to try.");
                int exo = NumberTyping();
                while ( exo != 0 && exo != 1 && exo != 2 && exo !=  3 && exo != 4 && exo != 5 && exo != 6 && exo != 7 && exo != 8)
                {
                    Console.WriteLine("Please write a number between 0 & 8");
                    exo = NumberTyping();
                }
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
                            else { unit = "Fahrenheit"; opposite = "Celsius"; }
                            Console.WriteLine("Correct value !\n"
                                             + "Enter the starting value please.");
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
                        
                        case 3:
                            Console.WriteLine("How many numbers de you want to compare ?\n"
                                                 + "  - 2 [TYPE 1]\n"
                                                 + "  - 4 [TYPE 2]\n");
                            int nnumber = NumberTyping();
                            while (nnumber != 1 && nnumber != 2)
                            {
                                Console.WriteLine("Please write 1 or 2 to pick the scenario");
                                nnumber = NumberTyping();
                            }
                            int[] numbers = new int[nnumber * 2];
                            for (int i = 1; i < nnumber * 2 + 1; i++)
                            {
                                Console.WriteLine("Please enter the number n°" + i + " please.");
                                numbers[i - 1] = NumberTyping();
                            }
                            Array.Sort(numbers);
                            //Console.WriteLine("Here are the sorted number:\n");
                            //for(int y =0; y < numbers.Length;y++)
                            //{
                            //    Console.Write(numbers[y] + " ");
                            //}
                            Console.WriteLine("Here is the biggest number: " + numbers[numbers.Length-1]);
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("What number do you want to use to calculate its factorial ?");
                            int factorialed = NumberTyping();
                            while (factorialed <= 0)
                            {
                                Console.WriteLine("Please enter a non-negative integer");
                                factorialed = NumberTyping();
                            }
                            int factorial=1;
                            for (int i = 1; i <= factorialed; i++)
                                factorial = factorial * i;
                            Console.Write( factorialed + "! = " + factorial);
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.WriteLine("Please choose the size of the array you want to work with (between 2 and 20)");
                            int arraysize = NumberTyping();
                            while (arraysize < 2 && arraysize > 20)
                            {
                                Console.WriteLine("Please enter a number between 2 and 20");
                                arraysize = NumberTyping();
                            }
                            int[] matharray = new int[arraysize];
                            for (int i = 1; i  < arraysize+1; i++)
                            {
                                Console.WriteLine("Please enter the number n°"+i+ " of your array");
                                matharray[i-1] = NumberTyping();
                            }
                            int arrayminimum = matharray[0];
                            foreach(int number in matharray)
                            {
                                if (number < arrayminimum) arrayminimum = number;
                            }
                            int arraymaximum = matharray[0];
                            foreach (int number in matharray)
                            {
                                if (number > arraymaximum) arraymaximum = number;
                            }
                            int arraysum = 0;
                            foreach (int number in matharray)
                            {
                                arraysum += number;
                            }
                            float arrayaverage = 0;
                            foreach (int number in matharray)
                            {
                                arrayaverage += number;
                            }
                            arrayaverage = arrayaverage/matharray.Length;

                            Console.WriteLine();
                            foreach (int number in matharray)
                            {
                                Console.Write("["+number+"] ");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Here are the infos about the array : \n" +
                                "Minimum: " + arrayminimum + "\n" +
                                "Maximum: " + arraymaximum + "\n" +
                                "Sum: " + arraysum + "\n" +
                                "Average: " + arrayaverage + "\n");
                            Console.ReadKey();
                            break;
                        case 6:
                            Console.WriteLine("Please choose the size of the array you want to work with (between 2 and 20)");
                            int cleanarraysize = NumberTyping();
                            while (cleanarraysize < 2 && cleanarraysize > 20)
                            {
                                Console.WriteLine("Please enter a number between 2 and 20");
                                arraysize = NumberTyping();
                            }
                            int[] cleanarray = new int[cleanarraysize];
                            for (int i = 1; i < cleanarraysize + 1; i++)
                            {
                                Console.WriteLine("Please enter the number n°" + i + " of your array");
                                cleanarray[i - 1] = NumberTyping();
                            }
                            Console.WriteLine("Array before cleaning:");
                            Console.WriteLine();
                            foreach (int number in cleanarray)
                            {
                                Console.Write("[" + number + "] ");
                            }
                            Console.WriteLine();
                            cleanarray = CleanArray(cleanarray);
                            Console.WriteLine("Array after cleaning:");
                            Console.WriteLine();
                            foreach (int number in cleanarray)
                            {
                                Console.Write("[" + number + "] ");
                            }
                            Console.ReadKey();
                            break;
                        case 7:
                            Console.WriteLine("Please enter the email you want to check the validity");
                            string email = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("The email to check: "+ email);
                            if (EmailCheck(email) == true)
                            {
                                Console.WriteLine("This can be used as an email");
                            }
                            else
                            {
                                Console.WriteLine("This cannot be used as an email");
                            }
                            Console.ReadKey();
                            break;
                        #endregion
                        case 8:
                            Console.WriteLine("Do you want to uppercase a word or a sentence ?\n"
                                                 + "  - Word [TYPE 1]\n"
                                                 + "  - Sentence [TYPE 2]\n");
                            int nnnumber = NumberTyping();
                            while (nnnumber != 1 && nnnumber != 2)
                            {
                                Console.WriteLine("Please write 1 or 2 to pick the scenario");
                                nnnumber = NumberTyping();
                            }
                            if ( nnnumber ==1)
                            {
                                Console.WriteLine("Please enter the word you want to uppercase");
                                string word = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("The input word: " + word);
                                word = WordUpper(word);
                                Console.WriteLine("The uppercased word: " + word);
                            }
                            if (nnnumber == 2)
                            {
                                Console.WriteLine("Please enter the sentence you want to uppercase");
                                string sentence = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("The input word: " + sentence);
                                sentence = SentenceUpper(sentence);
                                Console.WriteLine("The uppercased word: " + sentence);
                            }
                            Console.ReadKey();
                            break;
                        
                    }
                    break;
                }
                Console.WriteLine("To leave the program press ESCAPE, if you want to go back to the menu press any key");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
