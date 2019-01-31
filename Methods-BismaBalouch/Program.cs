/*
 Author: Bisma Balouch
 Date: 01/31/2019
 Comment: creating a method to demonstrate user input of their name.
 */
 using System;

namespace Methods_BismaBalouch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Please write your full name below:");
            //try-catch to validate user input
            try
            {
                FullName(Console.ReadLine()); 

            }//end of try
            catch
            {
                Console.WriteLine("Please enter your full name only.");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true); // closes the program
            }//end of catch

        }//end of method 1
        
        //it was in the same method that's why it couldn't operate it but once it was outside, it was able to show up
        //different method to pull the value of the user input
        static void FullName(string name)

        {
            Console.WriteLine("Hello " + name);
            Console.ReadKey(true);
        }

    }
}
