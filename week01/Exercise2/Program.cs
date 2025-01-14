using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
    //     Console.Write("What is your grade percentage?");
    //     string grade = Console.ReadLine();
    //     int number = int.Parse(grade);
    //     if (number >= 90)
    //     {
    //         Console.WriteLine("Your grade is an A");
    //     }
    //     if (number >= 80 && number < 90)
    //     {
    //         Console.WriteLine("Your grade is a B");
    //     }
    //     if (number >= 70 && number < 80)
    //     {
    //         Console.WriteLine("Your grade is a C");
    //     }
    //     if (number >= 60 && number < 70)
    //     {
    //         Console.WriteLine("Your grade is a D");
    //     }
    //     if (number <= 59)
    //     {
    //         Console.WriteLine("Your grade is an F");
    //     }
    //     if (number >= 70)
    //     {
    //         Console.WriteLine("Congratulations you passed the class");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Better luck for the next time!");
    //     }
    // }
    Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        double gradePercentage = double.Parse(input);
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You did not pass this time. Keep trying and you'll do better next time!");
        }
    }
}