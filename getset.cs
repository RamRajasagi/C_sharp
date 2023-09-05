using System;

//getters & setters = add security to fields(varibales) by encapsulation.

// properties = combine aspects of both fields and methods (share name with a field)
// get accessor = used to return the property value
// set accessor = used to assign a new value
// value keyword = defines the value being assigned by the set (parameter)
namespace getset;

class gs
{

    public int charge = 0; // this is the variabke that we want to have ristricted, predefined accesss (public) or sometimes even no access (private) to the outside world.
    public int charging(int charged)
    {
        Charge = charged; // here we are assigning the parameter to Charge get set method
        //Console.WriteLine($"the chargeing is {charge}");
        return charge;
    }

    public int Charge
    {
        get { return charge; }// then comes here to get the value
        set { charge = charge == 10 ? 50 : 80; }  // first comes here set the value        

    }
}

class gs2
{
    private int dozen_egg_bag;// this is a private variable 

    private string bag_style;
    private string bag_length;
    public string Bagcolor { get; set; } = "red"; // this is one way assiging values to a getset
    public string Bag_Style { get { return bag_style; } set { bag_style = "tote"; } } // this is one way assiging values to a getset
    public string Bag_Length { get { return bag_length; } set { bag_length = value; } } // this is one way assiging values to a getset

    public void buy_eggs()
    { // method to buy eggs
        Bag_Length = "short";//when we use value in get set, we declare the value in this way
        Console.Write($"Please buy at max a dozen egss,\nEnter the number of eggs you want to buy:");
        this.dozen_egg_bag = int.Parse(Console.ReadLine()); //we take the user input here
        Dozen_egg_bag = dozen_egg_bag; // now we assign out input to the get set and check if all our requiments are fullfilled. 
        //once we do this the varibale will be sent the proiperty of getset check everything and retuens the value
        Console.WriteLine($" you'll get {dozen_egg_bag} eggs in a {Bagcolor} bag, Btw your {Bag_Style} bag is {Bag_Length} and beautiful"); // that value can be displayed here
    }

    private int Dozen_egg_bag
    { // get set property 

        get { return this.dozen_egg_bag; } // finally this value will be returned. 
        set
        { // this is the setting that is supposed to happen
            if (dozen_egg_bag > 12)
            {
                Console.Write($"you can carry only upto a dozen eggs");
                dozen_egg_bag = 12;


            }
            else if (dozen_egg_bag < 1)
            {
                Console.WriteLine($"please buy atleast 1 egg");
                dozen_egg_bag = 1;
            }
            else
            {
                Console.WriteLine("all good");
            }
        }
    }


}