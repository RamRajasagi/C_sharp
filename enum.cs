using System;

// Enums (short for enumerations) in C# are a way to define a type with a fixed set of named values. that is when working with variables that are constants.

namespace enumz
{

    public class enu
    {
        // Define an enum named Colors with three possible values.
        public enum Colors
        {
            Red,
            Green,
            Blue
        }

        public void color()
        {
            // Using enum values.
            Colors myColor = Colors.Green;

            // Enums can be used in switch statements.
            switch (myColor)
            {
                case Colors.Red:
                    Console.WriteLine("The color is red.");
                    break;
                case Colors.Green:
                    Console.WriteLine("The color is green.");
                    break;
                case Colors.Blue:
                    Console.WriteLine("The color is blue.");
                    break;
                default:
                    Console.WriteLine("Unknown color.");
                    break;
            }
        }
    }
}