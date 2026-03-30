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

        // step 6 - creating rectangle2 with different height and width
        var rectangle2 = new Rectangle(3, 15);

        // step 7a - getting the description of rectangle2
        string description2 = rectangle2.DescribeRectangle();

        // step 7b - outputting the description
        Console.WriteLine(description2);

        // step 7c - drawing rectangle2 to the console
        rectangle2.DrawRectangle();
    }
}