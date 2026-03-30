using System;
using Lab9;

class Program
{
    static void Main()
    {
        // step 9 - ball1 is red, 10cm, rubber
        Ball ball1 = new Ball("Red", 10, "Rubber");

        // step 10 - calling Description on ball1
        ball1.Description();

        // step 11 - ball2 with my own choices
        Ball ball2 = new Ball("Blue", 20, "Leather");

        // step 12 - calling Description on ball2
        ball2.Description();
    }
}