using System;

class Program
{
    static void Main(string[] args)
    {   
        int choice = 0;

        // Create an instance of Prompts
        Prompts promptsObj = new Prompts();
        //intance of journals
        Journal journal = new Journal();
        
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following chioces:");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit\n");
            choice = int.Parse(Console.ReadLine());

            // Call the method and print the result
            string randomItem = promptsObj.GetRandomItem();


            if (choice == 1)
                {
                    // Write a new journal entry
                    Console.WriteLine(randomItem);
                    string response = Console.ReadLine();
                    journal.AddEntry(randomItem, response);

                }
                else if (choice == 2)
                {
                    // Display the journal entries
                    journal.DisplayAll();
                    // Add your logic here
                }
                else if (choice == 3)
                {
                    // Load the journal from a file
                    Console.WriteLine("You chose: Load");
                    // Add your logic here
                }
                else if (choice == 4)
                {
                    // Save the journal to a file
                    Console.WriteLine("You chose: Save");
                    // Add your logic here
                }
                else if (choice == 5)
                {
                    // Exit the program
                    Console.WriteLine("Goodbye!");
        
                }
                else
                {
                    // Invalid input
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                }

        }
    }
    
}