using System;

// Enums (short for enumerations) in C# are a way to define a type with a fixed set of named values. that is when working with variables that are constants.
//these are special type of classes that contain named constants like days of the week (mon,tue,wed..) or number between one to ten (one,two,...)
// there is number values assigned to each variable constant and object inside a enum starting from 0,1,2... 

namespace enumz
{

    public class enu
    {
        // Define an enum named Colors with three possible values.
        public enum Colors
        {
            Red,
            Green=2,
            Blue
        }

        public void prt_color(){
            int i =1;
            Console.WriteLine($"we are printing:{Colors.Red}");
            Console.WriteLine($"we are printing {(int)Colors.Green} color in the enum which is:{Colors.Green}");

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