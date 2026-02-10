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


