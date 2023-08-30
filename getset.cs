using System;

//getters & setters = add security to fields(varibales) by encapsulation, They're accessors found within properties

// properties = combine aspects of both fields and methods (share name with a field)
// get accessor = used to return the property value
// set accessor = used to assign a new value
// value keyword = defines the value being assigned by the set (parameter)
namespace getset;

class gs
{

    public int charge=0; 
    public int charging(int charged)
    {
        Charge = charged; // here we are assigning the parameter to Charge get set method
        //Console.WriteLine($"the chargeing is {charge}");
        return charge;
    }

    public int Charge{
        get{ return charge;}// then comes here to get the value
        set { charge = charge == 10 ? 50 : 80; }  // first comes here set the value        

    }
}