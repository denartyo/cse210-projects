using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
    //     Console.Write("What is the magic number?");
    //     string number = Console.ReadLine();
    //     int magic = int.Parse(number);
    // int answer = 0;
    // while (answer != magic)
    // {
    //     Console.Write("What is your guess?");
    //     string guess = Console.ReadLine();
    //      answer = int.Parse(guess);
    //     if (answer < magic)
    //     {
    //         Console.WriteLine("Higher");
    //     }
    //     else if (answer > magic)
    //     {
    //         Console.WriteLine("lower");
    //     }
    //     else if (answer == magic)
    //     {
    //         Console.WriteLine("Congratulations you guessed it.");
    //     }
    // }
    Random rand = new Random();
    int magic = rand.Next(1,100);   
    int answer = 0;
    while (answer != magic)
    {
       Console.Write("What is your guess?");
       string guess = Console.ReadLine();
       answer = int.Parse(guess);
       if (answer < magic)
        {
           Console.WriteLine("Higher");
        }
         else if (answer > magic)
      {
       Console.WriteLine("lower");
      }
       else if (answer == magic)
      {
       Console.WriteLine("Congratulations you guessed it.");
      }
   }

    }
    
}