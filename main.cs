// Created by:Emmanuel-Fofeyin Demars
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program tells uses a loop for multiplication
        int integerOne;
        int integerTwo;

        // input
        Console.WriteLine("This program uses a loops for multiplication");
        Console.WriteLine("");
        Console.WriteLine("You will need to input 2 numbers to be used");
        Console.WriteLine("");
        Console.WriteLine("Iput the first Number please:");
        integerOne = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Iput the first Number please:");
        integerTwo = Convert.ToInt32(Console.ReadLine());

        // process
        Console.WriteLine("");
        int counter = 0;
        var answer = 0;
        while (counter < integerTwo)
        {
            answer = answer + integerOne;
            counter++;
        }
        Console.WriteLine("The number is " + answer);
        Console.WriteLine("");
        Console.WriteLine("\nDone.");
    }
}