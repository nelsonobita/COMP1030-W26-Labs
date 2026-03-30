using System;

class Program
{
    public static string Alert(int level, string message, bool sound)
    {
        if (sound)
        {
            Console.Beep(200, 250);
        }

        string howSerious;

        switch (level)
        {
            case 1:
                Console.BackgroundColor = ConsoleColor.Green;
                howSerious = "Not really anything to fret about.";
                break;
            case 2:
                Console.BackgroundColor = ConsoleColor.Yellow;
                howSerious = "You should be worried.";
                break;
            case 3:
                Console.BackgroundColor = ConsoleColor.Red;
                howSerious = "It is time to freak out!";
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Black;
                howSerious = "Alert level is not set or is not valid.";
                break;
        }
        Console.Clear();

        string result = $"Alert level {level}. {message}. {howSerious}";
        return result;
    }

    static void Main()
    {
        string alertMessage = Alert(level: 3, message: "We are all out of coffee", sound: true);
        Console.WriteLine(alertMessage);
    }
}