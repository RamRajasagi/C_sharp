// In C# the complier always looks for Main Method to start the compiling from 
//and  Program.cs is a default csharp file with that method. other classes can be called from this method.
//These are different libs and namespaces that we import for a code to run successfully
// In C# everything is case sensitive.
using System;  // this is  default Lib
using DIfferent_IOs; // User defined Namesame
using loopsandconi;
using ds;
using testing_page;
using diff_methods;
using diff_operators;
using oops_concepts;
using ed;
using datatypes;
using getset;
using cvs;
using inter;
using abs_class;
using del_gate;
using exc_hand;
using enumz;
using genrick;

/// <summary>
/// this is the main code run area
/// </summary> // this is XML style comments
namespace MainCode
//Namespace is a collection of different things like other namespaces, classes, methods, etc. 
// like Last Name for person. there can be many types and kinds of items declared in a namespace (ram rajasagi, yeti rajasagi etc).
// we call in a snamespacve to import classes from other places like using System; System is a namespace | Console is a class | WriteLine is a method
{
    class MainClass //Class name. Any code that we write should be in a class.
    // a class can only have instance variables, constructors and methods.
    {
        static void Main(string[] args)
        // Code runs first from this method. in c# methods and functions are almost same with methods having void return type and functions have a value return type
        // (string[] args) -> this is parameter declaration
        // unless you call other methods into Main method they will not be executed. a program starts and ends in Main method only.
        {
            #region RoughPage 
            // regions are used to compartment a code. it has no effect on the code but for ease of use. 
            // Rough page:
            /*
             Console.WriteLine("Enter Name:");
             Console.WriteLine("Enter Name2:");
            string Name=Console.ReadLine();
            Console.WriteLine("Name:"+Name);
            */
            #endregion
            #region l1
            //Lesson 1: simple input and output from console.
            //DIfferent_IOs.IO_Test Cl_inst_IO_Test = new IO_Test(); //Creating a class instance to access the methods and variables 
            //with in the class and the new instace "Cl_inst_IO_Test" is called an object.
            //the IO_Test() is a default constructor; 
            //Cl_inst_IO_Test.SimpleIO(); //calling a method;
            //Cl_inst_IO_Test.Diff_WLs(); //fi a method has static in the decleration we dot neet instance like "Cl_inst_IO_Test" we can directly call "IO_Test.Diff_WLs();"
            #endregion
            #region l2
            // Lesson 2: data types 1. Boolean
            //datatypes.dtype diff_dtype = new dtype();
            //diff_dtype.m1();
            #endregion
            #region l3
            //Lesson 3: operators
            //diff_operators.many_operators oprs=new many_operators();
            //oprs.ABC_method(); 
            //diff_operators.Animal animal1 = new Dog();// Animal animal2 = new Cat(); Animal animal3 = new Cow();
            //diff_operators.animal_check.CheckAnimalType(animal1); // animal_check.CheckAnimalType(animal2); animal_check.CheckAnimalType(animal3);
            //nulling.nullby();
            //conversion.convert();
            #endregion
            #region l4
            //Lesson 4: Getter Setter
            //getset.gs gs_et = new gs();
            //int i = gs_et.charging(10);
            //Console.WriteLine($"new charge is {i}");
            //getset.gs2 gs_et2 = new gs2();
            //gs_et2.buy_eggs();
            #endregion
            #region l5
            //Lesson 5: Data Structures.
            //ds.diff_ds cl_inst_ds = new diff_ds();
            //cl_inst_ds.m1_arrays_static();
            //cl_inst_ds.m2_arrays_dynamic();
            //cl_inst_ds.m2_1_arraylist();
            //cl_inst_ds.m3_list();
            //cl_inst_ds.m4_list_cls_objs();
            #endregion
            #region l6
            //Lesson 6: Loops.
            //loopsandconi.diff_loops cl_inst_loops = new diff_loops();
            //cl_inst_loops.m_if_loop();
            //cl_inst_loops.m_while_loop();
            //cl_inst_loops.for_loop();
            //cl_inst_loops.m_foreach();
            //cl_inst_loops.switch_condi();
            //cl_inst_loops.m_dowhile_loop();
            //cl_inst_loops.m_try_catch();
            #endregion
            #region l7
            //Lesson 7: Methods and Functions            
            //diff_methods.method_types inst_method = new method_types(); // this class has constructors
            //diff_methods.method_types inst_method2 = new method_types("parameters"); // this class has constructors that takes parameters.
            //inst_method.m1_access_speci_method(); //public
            //inst_method.m2_generic_method(); // private, unable to call private method
            //inst_method.m3_returing_methods(); // void return
            //var v=inst_method.m4_returing_methods(); // with string return type
            //Console.WriteLine("value of k is:"+v);
            //inst_method.m5_pass_parameters(3,5);
            //method_types.m6_static_method(); // here we can access the static methods without creating any objects.
            //int i = 10;
            //inst_method.m8_method_parm_ref(ref i);
            //Console.WriteLine($"the value of i changed j as we are using ref parameters {i}");
            //i=10;
            //inst_method.m9_method_parm_ref(i);
            //Console.WriteLine($"the value of i dint change to j as we are using regular parameters {i}");
            //int y1; // though we have declared y1 and y2 in the method, this class desnt know them and we have to declare it again. 
            //int y2;
            //inst_method.m10_out_parm(10,20, out y1, out y2);
            //Console.WriteLine($"Sum y1: {y1} and Prod y2:{y2}");
            //3 ninst_method.m11_parm_array(1,2,3,4,5,6,7,8,9);
            //int l=9;
            //Console.WriteLine(l);
            //inst_method.out_method(out l); //exmple of using out refence
            //Console.WriteLine(l);
            //inst_method.print_this();
            //inst_method.m12_add(5,3);
            #endregion
            #region l8
            //Lesson 8 oops concepts
            //oops_concepts.encap new_encap = new encap();
            //new_encap.i=2;
            //var k=new_encap.multi();
            //Console.WriteLine(k);
            //oops_concepts.inhert_parent new_p = new inhert_parent(); // creating parent instance
            //var k=new_p.add(); //calling a function in parent method 
            //Console.WriteLine(k);
            //oops_concepts.inhert_child new_c = new inhert_child(); // creating child class instance, this has a cunstrut, 
            //though we run just this child class creation it will run partent class and its cunstructs before child class. 
            //k=new_c.add();// calling parent class method, so though we have a i varibale in child class it is still using the i value for parent class
            //Console.WriteLine(k);
            //var k=new_c.add2();// calling a child class method.
            //Console.WriteLine(k);
            //oops_concepts.inhert_parent new_c1 = new inhert_child(); // in this way you can access the hidden parent class method.  parent class instance calling child class 
            //var v1=new_c1.add2(); //though we are using the instance of child class and its object we are calling parent class ref variable new_c1,
            //Console.WriteLine(" so we get {0} insted of sum",v1);
            //oops_concepts.poly p = new oops_concepts.poly();
            //var pv = p.poly_add(3, 2);
            //var pv2 = p.poly_add(2, 3, 4);
            //Console.WriteLine($"with 2 varibales one method is called for sum of {pv} and with 3 variables it is {pv2}");
            //oops_concepts.poly_Circle PC = new oops_concepts.poly_Circle();
            //PC.Draw();
            #endregion
            #region l9
            //Lesson 9 class_v_struct            
            //var personClass = new PersonClass("Alice", 30); // instance of the class
            //var personStruct = new PersonStruct("Bob", 25); // instance of the struct
            //var personClassCopy = personClass; // this Copy by reference of the class above
            //personClass.Name = "Alice Johnson"; // Modifying  name property
            //personClass.PrintDetails(); // Outputs: Name: Alice Johnson, Age: 30
            //personClassCopy.PrintDetails(); // Outputs: Name: Alice Johnson, Age: 30 (same as original)
            //var personStructCopy = personStruct; // this Copy by value of the struct above
            //personStruct.Name = "Bob Smith"; // Modifying name property
            //personStruct.PrintDetails(); // Outputs: Name: Bob Smith, Age: 25
            //personStructCopy.PrintDetails(); // Outputs: Name: Bob, Age: 25 (original remains unchanged)
            #endregion
            #region l10
            //Lesson 10 interfaces
            //inter.Jeep jeep = new inter.Jeep();
            //jeep.jeep_runs();
            #endregion
            #region l11
            //Lesson 11 Abstract Classes
            //abs_class.cycle c = new cycle();
            //c.cycle_tyres();
            //abs_class.train_station tn = new train_station();
            //tn.cycle_tyres();
            //tn.trains();
            #endregion
            #region l12
            //Lesson 12 Delegates.
            // del_gate.dels d = new dels(); //class instance
            // dels.del1_1input del_d1 = new dels.del1_1input(d.car_names); // delegate intance
            // del_d1("Benz");
            // //multicast delegates is a process of combining similler signatured delegates i.e methods as well.
            // dels.del_sample d2,d3, d4,d5; // the above delegate doesnt work with these as they have different signatures. 
            // d2= new dels.del_sample(d.car_2nd_choice);  
            // d3= new dels.del_sample(d.car_3rd_choice);  
            // d4= new dels.del_sample(d.car_no_choice);          
            // d5=d2+d3+d4;
            // d5();
            #endregion
            #region l13
            // Lesson 13: Exception handling
            //exc_hand.ex_handle eh = new exc_hand.ex_handle();
            //eh.reading();
            //eh.writing();
            #endregion
            #region l14
            // Lesson 14: Enums
            enumz.enu en = new enu();
            //en.color();
            en.prt_color();
            #endregion

            #region l15
             // Create an instance of MyGenericClass with int as the type argument
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
            intGenericClass.PrintGenericValue(); 
            // Create an instance of MyGenericClass with string as the type argument
            MyGenericClass<string> stringGenericClass = new MyGenericClass<string>("Hello, Generics!");
            stringGenericClass.PrintGenericValue(); // Output: The value stored in the generic member is: Hello, Generics!
            #endregion
        }
    }
}
