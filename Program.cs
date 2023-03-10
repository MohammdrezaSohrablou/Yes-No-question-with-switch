
//--------- -   محمدرضا سهراب لو   - ---------//

//====>  تکلیف ششم
// در این فایل دو برنامه با الگوریتم مختلف برای تکلیف بله یا خیر با سوییچ وجود دارد
// در برنامه اول (حدس سن) با هر جواب بله یا خیر سوال جدیدی پرسیده میشود و در نهایت به جواب میرسد
// در برنامه دوم (تست شخصیت درونگرایی یا برونگرایی) تعدادی سوال بله و خیر طرح شده میباشد و الگوریتم با مقایسه جواب های کاربر به جواب نهایی میرسد 
using System;

class Program
{
    static void Main(string[] args)
    {
        int minAge = 1;
        int maxAge = 100;
        int guessedAge;
        int introverted = 0;
        int extroverted = 0;
        string z;
        string count;
        bool a;
        bool b;
        Console.WriteLine("Hello.");
        do
        {

            Console.WriteLine("do you want to playe age guessing game or have a Personality test?");
            Console.WriteLine("for guesseage game enter 0 and for test enter 1");
            do
            {
                string choice = (Console.ReadLine());
                if (choice == "0")
                {
                    gaGame();
                    b = false;
                }
                else if (choice == "1")
                {
                    test();
                    b = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter '0' or '1': ");
                    b = true;
                }
            } while (b);



            AskToContinue();
        } while (count.ToLower() == "y");
        Console.WriteLine("Good Luck !");


        // - - - - - - - - برنامه اول - - - - - - - -> guessing a number between 0 - 100 //

        void gaGame()
        {
            Console.WriteLine("Welcome to the age guessing game! Please think of an age between 1 and 100, and I will try to guess it.");
            while (true)
            {

                guessedAge = (minAge + maxAge) / 2;

                Console.WriteLine($"Is your age {guessedAge}?");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "yes":
                        Console.WriteLine("Great, I guessed your age!");
                        return;
                    case "no":
                        Console.WriteLine($"Is your age less than {guessedAge}?");
                        input = Console.ReadLine().ToLower();

                        switch (input)
                        {
                            case "yes":
                                maxAge = guessedAge - 1;
                                break;
                            case "no":
                                minAge = guessedAge + 1;
                                break;
                            default:
                                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'no' : ");
                        break;

                }
            }
        }

        // - - - - - - - - برنامه دوم - - - - - - - -> Personality test //

        void test()
        {
            Console.WriteLine("Welcome to the Personality test! Please keep calm and answer the questions carefully.");

            Console.WriteLine("1. do you prefer spending time in solitude?");
            getyorn();
            INTROVERTED();

            Console.WriteLine("2. do you prefer working in quiet?");
            getyorn();
            INTROVERTED();

            Console.WriteLine("3. do you think before you speak?");
            getyorn();
            INTROVERTED();

            Console.WriteLine("4. do you like being in a large groups?");
            getyorn();
            EXTROVERTED();

            Console.WriteLine("5. do you enjoy being the center of attention?");
            getyorn();
            EXTROVERTED();

            Console.WriteLine("6. do you need time alone to recharge and reflect?");
            getyorn();
            INTROVERTED();

            Console.WriteLine("7. do you make quick decisions?");
            getyorn();
            EXTROVERTED();

            Console.WriteLine("8. do you have a few friends?");
            getyorn();
            INTROVERTED();

            Console.WriteLine("9. do you think a lot about starting a relationship?");
            getyorn();
            INTROVERTED();

            Console.WriteLine("10. is it easy for you to speak in public?");
            getyorn();
            EXTROVERTED();

            Console.WriteLine("11. is it easy for you to meet new people?");
            getyorn();
            INTROVERTED();

            OutPutTest();

            void OutPutTest()
            {
                if (introverted > extroverted)
                {
                    Console.WriteLine("your type is introverted.");
                }
                else if (introverted < extroverted)
                {
                    Console.WriteLine("your type is extroverted.");
                }
            }

            void getyorn()
            {
                do
                {
                    z = Console.ReadLine().ToLower();
                    if (z == "yes")
                    {
                        a = false;

                    }
                    else if (z == "no")
                    {
                        a = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                        a = true;
                    }
                } while (a);
            }

            void INTROVERTED()
            {

                switch (z)
                {
                    case "yes":
                        introverted++;
                        break;
                    case "no":
                        extroverted++;
                        break;
                }
            }
            void EXTROVERTED()
            {
                switch (z)
                {
                    case "yes":
                        extroverted++;
                        break;
                    case "no":
                        introverted++;
                        break;
                }
            }
        }

        void AskToContinue()
        {
            Console.WriteLine("Do you want to restart? for restart enter 'y' and for stop enter 'n':");
            do
            {
                count = Console.ReadKey(true).KeyChar.ToString();
            } while (count.ToLower() != "y" && count.ToLower() != "n");
        }

    }
}
