using System;
using System.Collections.Generic;

namespace _4._2CSharpPracticePart2
{
    class Program
    {
        static void Main(string[] args)
        
           
            // In class practice:
            // Change the program to take in a list of names. Make sure the names are trimmed before they enter the list.
            // Change the GetInt() method to GetName().
            // Challenge: Prevent duplicates (case insensitive) from being added.

            // Entry point of programs in C#.
           {
                List<int> intList = new List<int>();

                int userInput = 1;
                do
                {
                    userInput = GetInt("Please enter a positive integer to add to the list, or a negative one to exit: ");
                    if (userInput > 0)
                    {
                        intList.Add(userInput);
                    }
                } while (userInput > 0);

                intList[6] = 10;

                // foreach will loop over every item in a collection, however they are typically treated as readonly (with "normal" data types anyways).
                foreach (int integer in intList)
                {
                    Console.WriteLine(integer);
                }
            }

            /*
                static: Tells C# to only keep one copy of the method in memory (important for OOP).
                int: Return type, the type of data coming out of the method.
                GetInt: Name of the method, how we call it.
                string: First parameter type, the type of input expected.
                prompt: First parameter/argument name, how we refer to that value in the method.
            */
            static int GetInt(string prompt)
            {
                int input;

                Console.Write(prompt);
                input = int.Parse(Console.ReadLine());

                return input;
            }
        }
    }


    

