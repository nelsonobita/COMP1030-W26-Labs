using System;

class Program
{
    static void Main()
    {
        // Assignment 1 -  C# Flooring program
        // Floor room calculating program

// step 2: Three flooring options (strings) that include price per sq. ft.
        string option1 = "Option 1: Hardwood - $5.00 per sq. ft.";
        string option2 = "Option 2: Laminate - $3.00 per sq. ft.";
        string option3 = "Option 3: Carpet - $2.00 per sq. ft.";

        // STEP 3: Variable to capture the user's flooring choice
        string choice = "";

        // STEP 4: Length and width (feet, one decimal point)
        double lengthFeet = 0.0;
        double widthFeet = 0.0;

        Console.WriteLine("Welcome to the C# Flooring calculator");

        // STEP 5: Ask for length
        Console.Write("Enter the room LENGTH in feet (e.g., 12.5): ");
        string lengthInput = Console.ReadLine();

        // STEP 6: Validate length is a number
        if (!double.TryParse(lengthInput, out lengthFeet))
        {
            Console.WriteLine("Error: Length must be a number (example: 12.5).");
            return;
        }

        // STEP 7: Ask for width
        Console.Write("Enter the room WIDTH in feet (e.g., 10.0): ");
        string widthInput = Console.ReadLine();

        // STEP 8: Validate width is a number
        if (!double.TryParse(widthInput, out widthFeet))
        {
            Console.WriteLine("Error: Width must be a number (example: 10.0).");
            return;
        }

        // STEP 9: Ask for flooring type (build sentence using the strings)
        Console.WriteLine();
        Console.WriteLine("Which flooring would you like?");
        Console.WriteLine($"A) {floorA}");
        Console.WriteLine($"B) {floorB}");
        Console.WriteLine($"C) {floorC}");
        Console.Write("Enter A, B, or C: ");

        // STEP 10: Validate the letter choice
        choice = (Console.ReadLine() ?? "").Trim().ToUpper();

        if (choice != "A" && choice != "B" && choice != "C")
        {
            Console.WriteLine("Error: Please enter only A, B, or C.");
            return;
        }



