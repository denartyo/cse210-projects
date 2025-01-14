using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        
        int number = 1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int total = 0;
        int count = 0;
        int largest = int.MinValue;

        foreach (int n in numbers)
        {
            total += n;
            if (n > largest)
            {
                largest = n;
            }
            count++;
        }
        double avg = (double)total / count;
        Console.WriteLine("The sum is: " + total);
        Console.WriteLine("The average is: " + avg);
        Console.WriteLine("The lasgest number is:" + largest);
        
    }
}