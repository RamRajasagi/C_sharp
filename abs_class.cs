//Abstract classes

using System;

namespace abs_class;

public abstract class abs_cls_cycle // this is how we declare abs class
{
    public abstract void cycle_tyres(); // abs class have abs methods
}

class cycle : abs_cls_cycle // when you inherit an abs class we "MAY" need to implement it 
{
    public override void cycle_tyres() // we use override to call methosd from the parent abstract class.
    {
        Console.WriteLine("the cycle has 2 tyres");
    }
}

public abstract class train : abs_cls_cycle // and if we choose not to implement it then we should have the the inherited class as abstrct as well
{ // but an abstract class can have decleration and define of its own objects

private int train_no=5;// abstrac t classes can have fields.
    public override void cycle_tyres() { }
    public void trains()
    {
        Console.WriteLine("There are no cycles here, only trains");
    }
}

class train_station : train // because train is an abstract class we can have an instance of that class so we can call the non abstract methd through the instance of this class.
// example in main program. 
{
    public override void cycle_tyres()
    {
        Console.WriteLine("This is train station");
    }
}