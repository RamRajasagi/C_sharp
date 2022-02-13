using System;
namespace diff_methods
{
    class method_types : Itest
    {
        public void print_this(){
            Console.WriteLine("testing interfaces");
        }
        public void m1_access_speci_method()
        {
            // here public or private are access specifiers this will tell if someone else can access the method or not.
            //the persence of void give the method permission for not retruning a value. 
            Console.WriteLine("my point");

        }

        private void m2_access_speci_method()
        {
            // testing private access specifier. you'll not be able too call this method from main method
            Console.WriteLine("my point");

        }
        // other access specifiers are:
        //internal: any class within the project can access them.
        // protected: only inherited class can access them. ie only child class can access
        //protected internal: a combination oof the above two.

        public void m3_returing_methods()
        {
            //we have the retrurn type as void. so it is not needed for the method to retunr a vlue.
            //console.wl() is not returning a value. it is a method with in this metjod that writes data to console.
            var k = "";
            Console.WriteLine("Enter value to k:");
            k = Console.ReadLine();
            while (k == "")
            {
                Console.WriteLine("No Value entered. Enter value to k:");
                k = Console.ReadLine();

            }
            Console.WriteLine("value of k is: " + k);

        }

        public string m4_returing_methods()
        {
            var k = "";
            Console.WriteLine("Enter value to k:");
            k = Console.ReadLine();
            while (k == "")
            {
                Console.WriteLine("No Value entered. Enter value to k:");
                k = Console.ReadLine();

            }
            return k;
        }

        public void m5_pass_parameters(int i, int j)
        { //here i and j are parameters
            Console.WriteLine("Adding {0} and {1}. Do you want to change the values press (y)", i, j);
            var d = Console.ReadLine();
            if (d == "y")
            {
                Console.WriteLine("Enter two new values");
                i = Convert.ToInt32(Console.ReadLine());//the data that comes from a terminal is always a var
                j = Convert.ToInt32(Console.ReadLine());
            }
            int t = i + j;
            Console.WriteLine("sum is: " + t);

        }

        public static void m6_static_method()
        {
            //for static method you dont need an instance.
            Console.WriteLine("My static point.");

        }
        public string const_test;
        public method_types()
        {
            //this is a constrctor. the name of this should be the same name as the class.
            //this is the first thing that is goin to be exectued when we create an insatnce of the class.
            const_test = "no arguments";
            Console.WriteLine(this.const_test);
        }

        public method_types(string s)
        {
            //this is constrctor can take argumnets just like a method and there can be multiple conts in a class
            //the only way we can differencate btw all these is by number of argumnets/parameters each connstrctur takes
            const_test = s;
            Console.WriteLine(this.const_test);
        }

        public void out_method(out int k){ //out brings out the value from the method//ref is similer to this 
            k=5;
            Console.WriteLine(k);

        }

    }

    enum vehicle_tyres{ //this is a special class that hold numeric costants that desnt change
    car=4,
    cycle=2,
    auto=3

    }

    interface Itest{ //interface is set of rule that has to be followed when a class inherits them.
    // they should generally start with I***
    void print_this(); // say this is the rule
     // however we cannot say what can be done in this method. 

    }

    public abstract class abs_class{ //this is simmiler to interface where what ever class inherits this class then that class needs to follow all the emthods of this class
    // the major diff btw this and interfaces is that we can say what the method does and also we can define access modifiers(public,pvt,etc)
    //these can have feilds
    //calss inhert from multiple interfaces but not from mutliple class at the same time.
    int k=3;
    public void print_this(){ // private by default
        Console.WriteLine("printing the data");        
    }

    public abstract void  other_print();//similer to interfaces where you rae declaring that there is no decleration by saying abstract.

    }

    

}