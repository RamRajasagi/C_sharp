using System;

namespace del_gate;
// these are type safe function pointers. meaning it is an object that points to a particualer style of methods that has the same style as the delegate.
// syntax: access-modifier delegate return-type name(parameters);
class dels
{
    public delegate void del1_1input(string car); // this is how we declare delegates
                                                  // we need to use an instance of a delegate to access the delegate. example is in the main program.
                                                  // the signature of a deleget should match the signature of the method it points to. 
    public delegate void del_sample(); // this is how we declare delegates
    
            
    public void car_names(string cars)
    {
        Console.WriteLine($"the name of the car is {cars}");
    }
/*
    public void car_2nd_choice(string cars)
    {
        Console.WriteLine($"the name of 2nd_choice car is {cars}");
    }

    public void car_3rd_choice(string cars)
    {
        Console.WriteLine($"the name of 3rd_choice car is {cars}");
    }

    public void car_no_choice(string cars)
    {
        Console.WriteLine($"the name of we dont want car is {cars}");
    }
*/

public void car_2nd_choice()
    {
        Console.WriteLine($"the name of 2nd_choice car is x");
    }

    public void car_3rd_choice()
    {
        Console.WriteLine($"the name of 3rd_choice car is y");
    }

    public void car_no_choice()
    {
        Console.WriteLine($"the name of we dont want car is z");
    }

}
