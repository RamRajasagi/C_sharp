using System;
//encapsulation
//inheritance
// there is no multiple class to one class inheritence . 
//abstraction - abilty to hide 
//polymorphism

namespace oops_concepts
{
    class encap
    { //process of combining a data member and method into one unit. 
      // this means it is abilty to crate a class

        public int i; // data member
        public int multi()
        { //method
            int k = i * 5;
            return k;
        }
    }

    class inhert_parent // if we define a sealed calss then it cant be a parent calss to anything other class. ex class sealed testclass{}
    {
        public int i2 = 10;
        public int add()
        {
            int h = i2 + 10;
            return h;
        }

        public int add2()
        {
            int h = 100;
            return h;
        }

        public inhert_parent(int c)
        {
            System.Console.WriteLine($"the value that i got from child class in {c}");
        }

        public inhert_parent()
        {
            // this does nothing, we have so that child class can have cunstructor without parameters
        }
    }

    class inhert_child : inhert_parent // c# allows only single class inhertance. so inhert_child can only have one parent class
    {
        public new int i2 = 20; // here we use new keyword so that we  hide the i2 from parent class
        public new int add2() // same as above, though we have an add2 method in parent class when we declare it this way it will hide the parent class add2 method and call the child class add2
        // when you use child class instance and call this method. 
        // this is called method hiding which includes method name, type(like int, float,etc) and  kind of parameters (like int, string, out, etc.)
        {
            int h = i2 + 10;
            int t = base.i2 + 10; // this is how we call base class hidden values
            Console.WriteLine($"here we are using i2(value 10) from parent class,so the sum is 10+i2: {t} \n i2 value in child class is 20 so the sum should be 30");
            return h;
        }

        public inhert_child() : base(300) // it will call the constructor of parent first (using : base()), and then it will execute its own constructor code.
        {
            Console.WriteLine($"we sent 300 to parent class"); 
        }

    }

    class poly
    { // polymorphism allows objects of different classes to be treated as objects of a common base class
        // this is method overloading style, dependind on how many aruments you pass it we pick that method to execute.
        // also called as compile time  polymorphism
        public int poly_add(int n, int m)
        {
            var z = n + m;
            return z;
        }

        public int poly_add(int n, int m, int o)
        {
            var z = n + m + o;
            return z;
        }
    }

    class poly_Shape // This type method overriding style of polymorphism. The method in the subclass overrides the method in the superclass.
                     // occurs during runtime and involves classes that are related through inheritance. 
    {
        public virtual void Draw() // for us to override we need a virtual method and a method that overrides.
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    class poly_Circle : poly_Shape
    {
        public override void Draw() // this method overides the above virtual method
        {
            Console.WriteLine("Drawing a circle");
        }
    }




}