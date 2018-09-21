/*
 * Name: Paul Xiong
 * Course: PROG2070
 * Assignment#1
 * 
 * Purpose: Console Application that works with a Square object
 * 
 */

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
                bool menuLoop = true;

                Console.WriteLine("Please enter the side length of the square:");
                int.TryParse(Console.ReadLine(), out value);

                if (value > 0)
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
                        
                        //obtain user input then pass to the switch statement
                        int.TryParse(Console.ReadLine(), out value);

                        switch (value)
                        {
                            default:
                                Console.WriteLine("Invalid selection");
                                break;
                            case 1:
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
                                    int.TryParse(Console.ReadLine(), out value);
                                    if (value > 0)
                                    {
                                        changeSideLoop = false;
                                        square.ChangeSide(value);
                                        Console.WriteLine("Side of square has been changed to: " + value.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input. Value provided must be greater than 0\n");
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
                                //exits program
                                Environment.Exit(0);
                                break;
                        } //end of switch                                  
                    } while (menuLoop);//end of the loop that forces menu to stay open
                }
                else
                {
                    Console.WriteLine("Invalid input. The value must be a positive integer.\n");
                }
            } while (programLoop);//end of loop that runs at initial start-up
        }
        
    }
}