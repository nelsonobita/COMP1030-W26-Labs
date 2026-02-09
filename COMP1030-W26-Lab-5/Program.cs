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


                // Print comma + spacing between values (no comma after last item)
                if (col < size)
                {
                    if (product < 10)
                        Console.Write(product + ",  "); // single digit -> comma + two spaces
                    else
                        Console.Write(product + ", ");  // 2+ digits -> comma + one space
                }
                else
                {
                    Console.Write(product); // last column
                }

                col++;
            }

            Console.WriteLine(); // next row
        }
    }
}
