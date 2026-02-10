using System;

class Program
{
    static void Main()
    {
        // Assignment 1 -  Georgian C# Flooring Shop Program
        // Floor room calculating program


        // three flooring options (strings) that include price per sq. ft.
        string floorA = "Bamboo Flooring - $5.00 per sq. ft.";
        string floorB = "Solid Oak Hardwood - $3.00 per sq. ft.";
        string floorC = "Porcelain Tile - $2.00 per sq. ft.";

        decimal priceA = 5.00m;
        decimal priceB = 3.00m;
        decimal priceC = 2.00m;

        // variable to capture the user's flooring choice
        string choice = "";

        // length and width (feet, one decimal point)
        double lengthFeet = 0.0;
        double widthFeet = 0.0;

        Console.WriteLine("Welcome to the C# Flooring calculator");

        // ask for length
        Console.Write("Enter the room LENGTH in feet (e.g., 12.5): ");
        string lengthInput = Console.ReadLine();

        // validate length is a number
        if (!double.TryParse(lengthInput, out lengthFeet))
        {
            Console.WriteLine("Error: Length must be a number (example: 12.5).");
            return;
        }

        // ask for width
        Console.Write("Enter the room WIDTH in feet (e.g., 10.0): ");
        string widthInput = Console.ReadLine();

        // validate width is a number
        if (!double.TryParse(widthInput, out widthFeet))
        {
            Console.WriteLine("Error: Width must be a number (example: 10.0).");
            return;
        }

        // ask for flooring type (build sentence using the strings)
        Console.WriteLine();
        Console.WriteLine("Which flooring would you like?");
        Console.WriteLine($"A) {floorA}");
        Console.WriteLine($"B) {floorB}");
        Console.WriteLine($"C) {floorC}");
        Console.Write("Enter A, B, or C: ");

        // validate the letter choice
        choice = (Console.ReadLine() ?? "").Trim().ToUpper();

        if (choice != "A" && choice != "B" && choice != "C")
        {
            Console.WriteLine("Error: Please enter only A, B, or C.");
            return;
        }

        // area calculation (sq. ft.)
        decimal area = (decimal)lengthFeet * (decimal)widthFeet;

        // if() statements for each flooring choice + math
        string selectedFloor = "";
        decimal selectedPrice = 0m;

        if (choice == "A")
        {
            selectedFloor = floorA;
            selectedPrice = priceA;
        }

        if (choice == "B")
        {
            selectedFloor = floorB;
            selectedPrice = priceB;
        }

        if (choice == "C")
        {
            selectedFloor = floorC;
            selectedPrice = priceC;
        }

        decimal totalCost = area * selectedPrice;

        // output summary sentence
        Console.WriteLine();
        Console.WriteLine("Results:");
        Console.WriteLine($"You picked: {selectedFloor}");
        Console.WriteLine($"Room size: {lengthFeet:F1} ft x {widthFeet:F1} ft = {area:F2} sq.ft.");
        Console.WriteLine($"Final cost: ${totalCost:F2}");

        Console.WriteLine();
        Console.WriteLine("Thank you for using The Georgian C# Flooring Shop!");
    }
}



