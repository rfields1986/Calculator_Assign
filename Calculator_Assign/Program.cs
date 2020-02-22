using System;

namespace Week_6_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            int leave, roll, lastchoice = 0;
            bool correctinput;
            Random choice5 = new Random();
            double mathinput1, mathinput2;
            do
            {
                Console.Clear();
                Console.WriteLine("CCCCCCCCCCCCC        AA        LL          CCCCCCCCCCCCC      VV          VV    111111           OOOOOOOO\n"
                + "CC                  AAAA       LL          CC                  VV        VV    11   11           OO    OO\n"
                + "CC                 AA  AA      LL          CC                   VV      VV          11           OO    OO\n"
                + "CC                AA    AA     LL          CC                    VV    VV           11           OO    OO\n"
                + "CC               AAAAAAAAAA    LL          CC                     VV  VV            11           OO    OO\n"
                + "CC              AA        AA   LL          CC                      VVVV    00       11      00   OO    OO\n"
                + "CCCCCCCCCCCCC  AA          AA  LLLLLLLLLL  CCCCCCCCCCCCC            VV     00   1111111111  00   OOOOOOOO\n");





                Console.Write("Welcome to the calculator! Please select an option:\n" +
                    "1. Add\n" +
                    "2. Subtract\n" +
                    "3. Multiply\n" +
                    "4. Divide\n" +
                    "5. Surprise me!\n" +
                    "6. Quit\n" +
                    "Your option: ");
                correctinput = Int32.TryParse(Console.ReadLine(), out leave);

                switch (leave)
                {
                    case 1:
                        do
                        {
                            Console.Write("Please enter the 1st number to add--> ");
                            correctinput = double.TryParse(Console.ReadLine(), out mathinput1);
                            if (correctinput != true)
                            {

                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                            }
                        } while (correctinput != true);
                        do
                        {


                            Console.Write("Please enter 2nd number to add--> ");
                            correctinput = double.TryParse(Console.ReadLine(), out mathinput2);
                            if (correctinput != true)
                            {

                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                            }
                        } while (correctinput != true);
                        Console.WriteLine($"The sum is {mathinput1 + mathinput2}\n" +
                            $"Press 1 to return to main menu OR 2 to quit calculator");
                        correctinput = Int32.TryParse(Console.ReadLine(), out leave);
                        do
                        {
                            if (leave == 2)
                            {
                                leave = 6;
                                break;
                            }
                            else if (leave == 1)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                                break;
                            }
                        } while (correctinput != true);
                        break;

                    case 2:
                        do
                        {
                            Console.Write("Please enter the 1st number to subtract--> ");
                            correctinput = double.TryParse(Console.ReadLine(), out mathinput1);
                            if (correctinput != true)
                            {

                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                            }
                        } while (correctinput != true);
                        do
                        {


                            Console.Write("Please enter 2nd number to subtract--> ");
                            correctinput = double.TryParse(Console.ReadLine(), out mathinput2);
                            if (correctinput != true)
                            {

                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                            }
                        } while (correctinput != true);
                        Console.WriteLine($"The difference is {mathinput1 - mathinput2}\n" +
                            $"Press 1 to return to main menu OR 2 to quit calculator");
                        correctinput = Int32.TryParse(Console.ReadLine(), out leave);
                        do
                        {
                            if (leave == 2)
                            {
                                leave = 6;
                                break;
                            }
                            else if (leave == 1)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                                break;
                            }
                        } while (correctinput != true);
                        break;
                    case 3:
                        do
                        {
                            Console.Write("Please enter the 1st number to multiply--> ");
                            correctinput = double.TryParse(Console.ReadLine(), out mathinput1);
                            if (correctinput != true)
                            {

                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                            }
                        } while (correctinput != true);
                        do
                        {


                            Console.Write("Please enter 2nd number to multiply--> ");
                            correctinput = double.TryParse(Console.ReadLine(), out mathinput2);
                            if (correctinput != true)
                            {

                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                            }
                        } while (correctinput != true);
                        Console.WriteLine($"The product is {mathinput1 * mathinput2}\n" +
                            $"Press 1 to return to main menu OR 2 to quit calculator");
                        correctinput = Int32.TryParse(Console.ReadLine(), out leave);
                        do
                        {
                            if (leave == 2)
                            {
                                leave = 6;
                                break;
                            }
                            else if (leave == 1)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                                break;
                            }
                        } while (correctinput != true);
                        break;
                    case 4:
                        do
                        {
                            Console.Write("Please enter the 1st number to divide--> ");
                            correctinput = double.TryParse(Console.ReadLine(), out mathinput1);
                            if (correctinput != true)
                            {

                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                            }
                        } while (correctinput != true);
                        do
                        {


                            Console.Write("Please enter 2nd number to divide--> ");
                            correctinput = double.TryParse(Console.ReadLine(), out mathinput2);
                            if (correctinput != true)
                            {

                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                            }
                        } while (correctinput != true);
                        Console.WriteLine($"The quotient is {mathinput1 / mathinput2}\n" +
                            $"Press 1 to return to main menu OR 2 to quit calculator");
                        correctinput = Int32.TryParse(Console.ReadLine(), out leave);
                        do
                        {
                            if (leave == 2)
                            {
                                leave = 6;
                                break;
                            }
                            else if (leave == 1)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Bad input\nPress any key to retry");
                                Console.ReadLine();
                                break;
                            }
                        } while (correctinput != true);
                        break;
                    case 5:
                        roll = choice5.Next(1, 5);


                        switch (roll)
                        {
                            case 1:
                                do
                                {
                                    Console.Write("Please enter the 1st number to add--> ");
                                    correctinput = double.TryParse(Console.ReadLine(), out mathinput1);
                                    if (correctinput != true)
                                    {

                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine(); ;
                                    }
                                } while (correctinput != true);
                                do
                                {


                                    Console.Write("Please enter 2nd number to add--> ");
                                    correctinput = double.TryParse(Console.ReadLine(), out mathinput2);
                                    if (correctinput != true)
                                    {

                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine();
                                    }
                                } while (correctinput != true);
                                Console.WriteLine($"The sum is {mathinput1 + mathinput2}\n" +
                                    $"Press 1 to return to main menu OR 2 to quit calculator");
                                correctinput = Int32.TryParse(Console.ReadLine(), out lastchoice);
                                do
                                {
                                    if (lastchoice == 2)
                                    {
                                        leave = 6;
                                        break;
                                    }
                                    else if (lastchoice == 1)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine(); ;
                                        break;
                                    }
                                } while (correctinput != true);
                                break;

                            case 2:
                                do
                                {
                                    Console.Write("Please enter the 1st number to subtract--> ");
                                    correctinput = double.TryParse(Console.ReadLine(), out mathinput1);
                                    if (correctinput != true)
                                    {

                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine();
                                    }
                                } while (correctinput != true);
                                do
                                {


                                    Console.Write("Please enter 2nd number to subtract--> ");
                                    correctinput = double.TryParse(Console.ReadLine(), out mathinput2);
                                    if (correctinput != true)
                                    {

                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine();
                                    }
                                } while (correctinput != true);
                                Console.WriteLine($"The difference is {mathinput1 - mathinput2}\n" +
                                    $"Press 1 to return to main menu OR 2 to quit calculator");
                                correctinput = Int32.TryParse(Console.ReadLine(), out lastchoice);
                                do
                                {
                                    if (lastchoice == 2)
                                    {
                                        leave = 6;
                                        break;
                                    }
                                    else if (lastchoice == 1)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine();
                                        break;
                                    }
                                } while (correctinput != true);
                                break;
                            case 3:
                                do
                                {
                                    Console.Write("Please enter the 1st number to multiply--> ");
                                    correctinput = double.TryParse(Console.ReadLine(), out mathinput1);
                                    if (correctinput != true)
                                    {

                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine();
                                    }
                                } while (correctinput != true);
                                do
                                {


                                    Console.Write("Please enter 2nd number to multiply--> ");
                                    correctinput = double.TryParse(Console.ReadLine(), out mathinput2);
                                    if (correctinput != true)
                                    {

                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine();
                                    }
                                } while (correctinput != true);
                                Console.WriteLine($"The product is {mathinput1 * mathinput2}\n" +
                                    $"Press 1 to return to main menu OR 2 to quit calculator");
                                correctinput = Int32.TryParse(Console.ReadLine(), out lastchoice);
                                do
                                {
                                    if (lastchoice == 2)
                                    {
                                        leave = 6;
                                        break;
                                    }
                                    else if (lastchoice == 1)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine();
                                        break;
                                    }
                                } while (correctinput != true);
                                break;
                            case 4:
                                do
                                {
                                    Console.Write("Please enter the 1st number to divide--> ");
                                    correctinput = double.TryParse(Console.ReadLine(), out mathinput1);
                                    if (correctinput != true)
                                    {

                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine();
                                    }
                                } while (correctinput != true);
                                do
                                {


                                    Console.Write("Please enter 2nd number to divide--> ");
                                    correctinput = double.TryParse(Console.ReadLine(), out mathinput2);
                                    if (correctinput != true)
                                    {

                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine();
                                    }
                                } while (correctinput != true);
                                Console.WriteLine($"The quotient is {mathinput1 / mathinput2}\n" +
                                    $"Press 1 to return to main menu OR 2 to quit calculator");
                                correctinput = Int32.TryParse(Console.ReadLine(), out lastchoice);
                                do
                                {
                                    if (lastchoice == 2)
                                    {
                                        leave = 6;
                                        break;
                                    }
                                    else if (lastchoice == 1)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("Bad input\nPress any key to retry");
                                        Console.ReadLine();
                                        break;
                                    }
                                } while (correctinput != true);
                                break;

                        }
                        break;




                }
            } while (leave != 6 && lastchoice != 2);
            Console.WriteLine("Goodbye");



        }

    }
}
