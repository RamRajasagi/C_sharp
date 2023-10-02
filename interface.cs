// interface is like a contract given to a class saying that these when inherited should be implement. 
//interfaces can only have declaration but no implementations and it cant have field like int i or float, etc
//all the members are public by default and can be changes
// class and struct can inherit interfaces

using System;

namespace inter;

interface Ivechile { // it is custom to declare interfaces to start with an I 
    void jeep_runs();// we cant define what this method does in an interface
}

interface Ifuel{
    string Fuel{get;set;} 
}
class Jeep : Ivechile, Ifuel {

    private string fuel;

    public string Fuel{get {return fuel;} set{fuel = value;}}
    //Fuel="dsl"; // this wont work coz class cannot constant declaration
          
    public void jeep_runs() { // this is how you call an interface method using public void
    // and if you run into a use case when there is jeep_runs in 2nd inhered interface then we explicitly specify saying interface2.jeep_runs, which is called explicit interface implementation
        int tyres = 4;
        Fuel="Dsl";
        Console.WriteLine("Jeep has {0} tyres and runs on {1} as fuel" , tyres,Fuel);

    }
}