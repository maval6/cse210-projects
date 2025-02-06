using System;

class Program
{
    static void Main(string[] args)
    {
        // Set up the scripture reference and text.
        // You can modify these to test with different scriptures.
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life";

        Scripture scripture = new Scripture(reference, scriptureText);

        // Continue until all words are hidden or the user types "quit".
        while (true)
        {
            // Clear the console screen.
            Console.Clear();
            
            // Display the scripture (including the reference and the text with hidden words).
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(); // Blank line for spacing

            // If all words are hidden, end the program.
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words have been hidden. Press any key to exit.");
                Console.ReadKey();
                break;
            }

            // Prompt the user to continue or quit.
            Console.WriteLine("Press ENTER to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }
            else
            {
                // Hide a few random words (adjust the number as desired).
                scripture.HideRandomWords(3);
            }
        }
    }
}