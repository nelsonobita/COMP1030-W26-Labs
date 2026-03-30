namespace COMP1030_W26_Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // step 1 - array of ice cream flavors (picked 8)
            string[] iceCreamFlavors = { "Vanilla", "Chocolate", "Strawberry", "Mint Chip", "Cookie Dough", "Rocky Road", "Butter Pecan", "Mango Sorbet" };

            // step 2 - storing the length of the array
            int flavorCount = iceCreamFlavors.Length;

            // STEP 3: Output intro sentence for the FOR() loop section
            Console.WriteLine("Here are all the ice cream flavors available at our stand (using a FOR loop):");

            // STEP 4 & 5: Build a FOR() loop using flavorCount to control iterations, output each element
            for (int i = 0; i < flavorCount; i++)
            {
                Console.WriteLine(iceCreamFlavors[i]);
            }

            // step 6 - same thing but letting them know we're switching to foreach now
            Console.WriteLine("\nHere are all the ice cream flavors available at our stand (using a FOREACH loop):");

            // step 7 and 8 - foreach loop, cleaner since we dont need the index
            foreach (string flavor in iceCreamFlavors)
            {
                Console.WriteLine(flavor);
            }
        }
    }