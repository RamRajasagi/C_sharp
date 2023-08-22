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


namespace MainCode 
//Namespace is a collection of different things like other namespaces, classes, methods, etc. 
// like Last Name for person. there can be many types and kinds of items declared in a namespace (ram rajasagi, yeti rajasagi etc).
// we call in a snamespacve to import classes from other places like using System; System is a namespace | Console is a class | WriteLine is a method
{
    class MainClass //Class name. Any code that we write should be in a class.
    {
        static void Main(string[] args) 
        // Code runs first from this method. in c# methods and functions are almost same with methods having void return type and functions have a value return type
        // (string[] args) -> this is parameter declaration
        // unless you call other methods into Main method they will not be executed. a program starts and ends in Main method only.
        {
            // Rough page:
            /*
             Console.WriteLine("Enter Name:");
             Console.WriteLine("Enter Name2:");
            string Name=Console.ReadLine();
            Console.WriteLine("Name:"+Name);
            */

            //Lesson 1: simple input and output from console.
            //DIfferent_IOs.IO_Test Cl_inst_IO_Test = new IO_Test(); //Creating a class instance to access the methods and variables with in the class and the new instace "Cl_inst_IO_Test" is called an object.
            //Cl_inst_IO_Test.SimpleIO(); //calling a method;
            //Cl_inst_IO_Test.Diff_WLs(); //calling a method

            // Lesson 1.1: data types 1. Boolean
            //datatypes.dtype diff_dtype = new dtype();
            //diff_dtype.m1();

            
/*
            //Lesson 2: Loops.
            loopsandconi.diff_loops cl_inst_loops = new diff_loops();
            //cl_inst_loops.m_if_loop();
            //cl_inst_loops.m_while_loop();
            //cl_inst_loops.for_loop();
            //cl_inst_loops.m_foreach();
            //cl_inst_loops.switch_condi();
            //cl_inst_loops.m_try_catch();

            //Lesson 2.1 operators
            diff_operators.many_operators oprs=new many_operators();
            //oprs.m1_turnary_op();            

            //Lesson 3: Data Structures.
            ds.diff_ds cl_inst_ds = new diff_ds();
            //cl_inst_ds.m1_arrays_static();
            //cl_inst_ds.m2_arrays_dynamic();
            //cl_inst_ds.m3_list();
            //cl_inst_ds.m4_list_cls_objs();

            //Lesson 4: Methods and Functions            
            diff_methods.method_types inst_method = new method_types(); // this class has constructors
            //diff_methods.method_types inst_method2 = new method_types("parameters"); // this class has constructors that takes parameters.
            //inst_method.m1_access_speci_method(); //public
            //inst_method.m2_generic_method(); // private, unable to call private method
            //inst_method.m3_returing_methods(); // void return
            //var v=inst_method.m4_returing_methods(); // with string return type
            //Console.WriteLine("value of k is:"+v);
            //inst_method.m5_pass_parameters(3,5);
            //method_types.m6_static_method(); // here we can access the static methods without creating any objects.
            //int l=9;
            //Console.WriteLine(l);
            //inst_method.out_method(out l); //exmple of using out refence
            //Console.WriteLine(l);
            //inst_method.print_this();


            //Lesson 5 oops concepts
            oops_concepts.encap new_encap=new encap();
            //new_encap.i=2;
            //var k=new_encap.multi();
            //Console.WriteLine(k);
            oops_concepts.inhert_parent new_p= new inhert_parent();
            //k=new_p.add();
            //Console.WriteLine(k);
            oops_concepts.inhert_child new_c= new inhert_child();
            //k=new_c.add();
            //Console.WriteLine(k);
            //k=new_c.add2();
            //Console.WriteLine(k);

            //Lesson 6: Events and delegates
            ed.action_here act_here = new action_here(); // instan publisher class
            ed.reaction react = new reaction(act_here); //insta subscriber class and calling them with the publisher
            //act_here.main_action();
            ed.delegatez del_class= new delegatez();
           // del_class.assign_delg_method();
            ed.lambda_exp lamb= new lambda_exp();

*/            

        }
    }
}
