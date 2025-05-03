using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101); 

        Console.WriteLine("I have a magic number between 1 and 10.");
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());  

        string hint = "";

        while (guess != magic)  
        {
            if (guess < magic)
            {
                hint = "higher";  
            }
            else if (guess > magic)
            {
                hint = "lower"; 
            }

            Console.WriteLine($"Hint: {hint}");  
            Console.Write("Try again: ");
            guess = int.Parse(Console.ReadLine());  
        }

        Console.WriteLine("You won, you guessed correctly!");
    }
}