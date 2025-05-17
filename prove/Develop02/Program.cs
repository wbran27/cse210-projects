using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following chioces:");
        Console.WriteLine("1.Write\n 2.Display\n 3.Load\n 4.Save\n 5.Quit\n");
                // Create an instance of Prompts
        Prompts promptsObj = new Prompts();

        // Call the method and print the result
        string randomItem = promptsObj.GetRandomItem();
        Console.WriteLine($"Randomly selected item: {randomItem}");


    }
}