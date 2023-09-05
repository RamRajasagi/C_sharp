using System;
//in c# methods and functions are almost same with methods having void return type and functions have a value return type
/*

template: 
access modifier return_type method_name(input parameters){
    body
}
1. access modifiers:  (public/private/internal/protected) and with or without static. 
if static is there then we dont need instance of class declared: we can just call classname.method() to access the method.
 if not then it is called instance method and should called after we craete class instacnce class k = new class(); k.method() 
 we declare the objects of a class static if we are surethat these values dosent change: 
 for example: static var sun_rise="east", static var 12_inch="30 CM"
 this helps with memory allocation as static members has only one memory acclocated an we keep on calling the same memory location, where as instance members has memory acclocated whenever you crate an instance of it. 

2. retrun type: thsi can void or any thoer data type like int, sting etc.

3. name: can be anything

4. parameters: this is a variabale that you are goign to use to send the data to the method ex: public string m1(string vari11)

*/
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
        //protected: only inherited class can access them. ie only child class can access
        //protected internal: a combination oof the above two.

        public void m3_returing_methods()
        {
            //we have the return type as void. so it is not needed for the method to return a vlue.
            //console.wl() is not returning a value. it is a method with in this method that writes data to console.
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
        
        public void m8_method_parm_ref( ref int j){ // using ref parameters, they access the same memery though we declare them as 2 different varibales. 
            j=100;
        }

        public void m9_method_parm_ref( int j){
            j=100;
        }

        //expression-bodied member syntax.
         public int m12_add(int a, int b) => a + b; //  is an example of a concise method declaration using lambda expressions for short methods.

        public void m10_out_parm(int x1, int x2, out int y1, out int y2){ // out paramerts is a way of sending out the data from the method through these parameters. similler to return. 
            y1=x1+x2;// these out paramerts can be used, if we want send out more than one output from a method.
            y2=x1*x2;
        }

        public void m11_parm_array(params int[] x){ // method to accept a varying number of arguments of the same type, like array as input parameter.
        // should always start with params while declaring the parameter and this shoudl be the last thing you declare in the list of param 
            Console.WriteLine($"Leanth of the array is {x.Length} \n The elements");
            foreach(var k in x){
                Console.Write("{0}\t",k);
            }
        }

        public string const_test;// declaring a calss variable for the constructor below
        public method_types() // example1 const
        {
            //this is a constrctor. the name of this should be the same name as the class. however they cant return a value. 
            //this is the first thing that is goin to be exectued when we create an insatnce of the class.
            const_test = "no arguments constructor, example 1 ";
            Console.WriteLine(this.const_test);
        }

        public method_types(string s) // example2 const
        {
            //this is constrctor can take argumnets just like a method and there can be multiple conts in a class, however they cant return a value. 
            //the only way we can differencate btw all these is by number of argumnets/parameters each connstrctur takes
            const_test = s;
            Console.WriteLine(this.const_test); // "this" keyword is used to refer objects/instance of that particuar class. we cant call statc objects using 'this' keyword bcoz 
            //this. is like craeting instance of the class and we cant crate instances fro ststic objects
        }

        static method_types(){
            //this is a static constructor mostly used to initilise static member of a class
            // this is always run first before the regular constructor
            Console.WriteLine("i am first");
        }

        ~method_types(){} // this is a destructor that cleans up any memory accltion done to a constructor 

        // when you have multiple contructors based on the number of arguments you are providing while cerating the calss instance it will go to that constructor.
        // in the above example when you crate a class instance like method_types mm= new method_types() it will go to example1 and if you create instance like 
        //method_types mm= new method_types("test") then it will go to example2 


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