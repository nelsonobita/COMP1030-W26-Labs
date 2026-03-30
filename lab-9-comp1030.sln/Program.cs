using Shapes;

class Program
{
    static void Main()
    {
        // step 3 - creating rectangle1 with a height and width
        var rectangle1 = new Rectangle(5, 10);

        // step 4a - getting the description of rectangle1
        string description1 = rectangle1.DescribeRectangle();

        // step 4b - outputting the description
        Console.WriteLine(description1);

        // step 4c - drawing rectangle1 to the console
        rectangle1.DrawRectangle();
    }
}