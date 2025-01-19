using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the welcome message to the user
        DisplayWelcomeMessage();

        // Prompt the user for their name and store it in userName
        string userName = PromptUserName();

        // Prompt the user for their favorite number and store it in userNumber
        int userNumber = PromptUserNumber();

        // Calculate the square of the user's favorite number
        int squaredNumber = SquareNumber(userNumber);

        // Display the result to the user
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();  // Reads the name input from the user
        return name;
    }

    // Function to prompt the user for their favorite number and return it as an integer
    static int PromptUserNumber()
    {
        int number; // Declare a variable to store the user's number

        // Loop until a valid integer is entered
        while (true)
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();  // Read user input

            // Try to parse the input as an integer
            if (int.TryParse(userInput, out number))
            {
                // If parsing succeeds, return the valid number
                return number;
            }
            else
            {
                // If parsing fails, display an error message and prompt again
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

    // Function to calculate and return the square of a given number
    static int SquareNumber(int number)
    {
        int square = number * number;  // Calculate the square of the number
        return square;  // Return the result
    }

    // Function to display the result with the user's name and squared number
    static void DisplayResult(string name, int square)
    {
        // Display a message showing the user's name and the squared number
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
