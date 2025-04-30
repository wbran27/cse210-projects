using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
    
        Console.Write("what it the magic number: ");
        int magic = int.Parse(Console.ReadLine());
        Console.Write("what is your guess: ");
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
            else if (guess == magic)
            {
                hint = "correct guess";
            }
            else
            {
                hint = "incorrect input";
            }
            Console.WriteLine($"hint: {hint}");
            Console.Write("try again: ");
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You won, you guessed correctly");


    }
}