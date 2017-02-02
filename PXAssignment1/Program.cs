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
            bool programLoop = true;
            
            //loop that runs until a valid (numeric) entry is provided at first start-up
            do
            {
                //instantiate Square object and declare variables
                Square square = new Square();
                int value;
                bool errorCheck;
                bool menuLoop = true;

                Console.WriteLine("Please enter the side length of the square:");
                errorCheck = int.TryParse(Console.ReadLine(), out value);

                if (errorCheck && value > 0)
                {
                    square.ChangeSide(value);

                    //loop that runs the program until user exits
                    do
                    {
                        Console.WriteLine("\nPlease select an operation:");
                        Console.WriteLine("1. Get Square Side Length");
                        Console.WriteLine("2. Change Square Side Length");
                        Console.WriteLine("3. Get Square Perimeter");
                        Console.WriteLine("4. Get Square Area");
                        Console.WriteLine("5. Exit");
                        
                        //obtain user input then feed to the switch statement
                        int.TryParse(Console.ReadLine(), out value);
                        switch (value)
                        {
                            case 0:
                                //invalid operation menu selection
                                Console.WriteLine("Invalid selection.\n");
                                break;
                            case 1:
                                //get the side length of square
                                value = square.GetSide();
                                Console.WriteLine("Your current square side length is: " + value.ToString());
                                break;
                            case 2:
                                //change square side length
                                bool changeSideLoop = true;

                                //loop that runs until user provides valid input
                                do
                                {
                                    Console.WriteLine("Input the new value for the side of square:");
                                    errorCheck = int.TryParse(Console.ReadLine(), out value);
                                    if (errorCheck && value > 0)
                                    {
                                        changeSideLoop = false;
                                        square.ChangeSide(value);
                                        Console.WriteLine("Side of square has been changed to: " + value.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input. Value provided cannot be less than 0\n");
                                    }
                                } while (changeSideLoop);
                                break;
                            case 3:
                                //get perimeter of square
                                value = square.GetPerimeter();
                                Console.WriteLine("The perimeter of the square is: " + value.ToString());
                                break;
                            case 4:
                                //get area of square
                                value = square.GetArea();
                                Console.WriteLine("The area of the square is: " + value.ToString());
                                break;
                            case 5:
                                //exit the program
                                Environment.Exit(0);
                                break;
                        }//end of the switch statement for menu options
                    } while (menuLoop);//end of the loop that forces menu to stay open
                }
                else
                {
                    Console.WriteLine("Invalid input. The value must be a positive integer.\n");
                }
            } while (programLoop);//end of loop that allows the program to proceed to menu
        }
    }
}