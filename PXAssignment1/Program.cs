using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PXAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square;
            int side = 0;
            bool isValid = false;
            bool menu = true;

            // do loop that runs until a valid (numeric) entry is provided at first start-up
            do
            {
                try
                {
                    Console.WriteLine("Please enter the side length of the square:");
                    string input = Console.ReadLine();

                    //parse and check for valid user input
                    if (int.Parse(input) <= 0)
                    {
                        Console.WriteLine("Input cannot be a negative value or equal to 0");
                        Console.WriteLine();
                    }
                    else
                    {
                        side = int.Parse(input);
                        isValid = true;
                        int value;
                        menu = true;
                        square = new Square(side);
                        
                        // do loop that runs until the user specifically chooses to exit/end program
                        do
                        {
                            Console.WriteLine("Please select an operation:");
                            Console.WriteLine("1. Get Square Side Length");
                            Console.WriteLine("2. Change Square Side Length");
                            Console.WriteLine("3. Get Square Perimeter");
                            Console.WriteLine("4. Get Square Area");
                            Console.WriteLine("5. Exit");

                            //variable to hold the value of selection
                            int option = int.Parse(Console.ReadLine());

                            //switch for the menu
                            switch (option)
                            {
                                //get the length
                                case 1:
                                    value = square.GetSide();
                                    Console.WriteLine("Your current square side length is: " + value.ToString() + "\n");
                                    break;
                                //change square side length
                                case 2:
                                    try
                                    {
                                        Console.WriteLine("Please input the new side length of the square: ");
                                        string temp = Console.ReadLine();

                                        if (int.Parse(temp) <= 0)
                                        {
                                            Console.WriteLine("Input cannot be a negative value or equal to 0");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            value = int.Parse(temp);
                                            int newSide = square.ChangeSide(value);
                                            square = new Square(newSide);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("The entry must be numeric");
                                        Console.ReadLine();
                                    }
                                    break;
                                //get perimeter of square
                                case 3:
                                    value = square.GetPerimeter();
                                    Console.WriteLine("The perimeter of the square is: " + value.ToString() + "\n");
                                    break;
                                //get surface area of square
                                case 4:
                                    value = square.GetArea();
                                    Console.WriteLine("The area of the square is: " + value.ToString() + "\n");
                                    break;
                                //exit the program
                                case 5:
                                    //exits the program
                                    menu = false;
                                    Environment.Exit(0);
                                    break;
                            }//end of the switch statement for menu options
                        } while (menu);//end of the loop that forces menu to stay open
                    }
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("The entry must be numeric");
                    Console.ReadLine();
                }
            } while (!isValid);//end of loop that allows the program to proceed to menu
        }
    }
}
