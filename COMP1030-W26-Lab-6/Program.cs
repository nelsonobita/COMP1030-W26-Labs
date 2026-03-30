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

            // step 3 - telling the user we're about to list flavors with a for loop
            Console.WriteLine("Here are all the ice cream flavors available at our stand (using a FOR loop):");

            // step 4 and 5 - for loop using flavorCount so it knows when to stop
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
}