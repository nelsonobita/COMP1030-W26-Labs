using System;

class Program
{
    static void Main()
    {
        const int size = 10;

        // Outer loop (for): rows 1 to 10
        for (int row = 1; row <= size; row++)
        {
            // Inner loop (while): columns 1 to 10
            int col = 1;
            while (col <= size)
            {
                int product = row * col;
