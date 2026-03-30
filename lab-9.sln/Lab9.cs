namespace Lab9
{
    class Ball
    {
        public string Color;
        public int Size;
        public string Material;

        public Ball(string color, int size, string material)
        {
            Color = color;
            Size = size;
            Material = material;
        }

        public void Description()
        {
            string description = $"This ball is {Color}, {Size} cm in diameter, and made of {Material}.";
            Console.WriteLine(description);
        }
    }
}