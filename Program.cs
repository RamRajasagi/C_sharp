// In C# the complier always looks for Main Method to start the compiling from 
//and  Program.cs is a default csharp file with that method. other classes can be called from this method.
//These are different libs and namespaces that we import for a code to run successfully
using System;  // this is  default Lib
using DIfferent_IOs; // User defined Namesame
using loopsandconi;
using ds;
using testing_page;
using diff_methods;
using diff_operators;

namespace MainCode 
//Namespace is like Last Name for person. It helps in making the class name below unique.
// In Ram Rajasagi Ram is like class name and Rajasagi is like namespace.
{
    class MainClass //Class name
    {
        static void Main(string[] args) // Code runs first from this method
        {
            // Rough page:


            //Lesson 1: simple input and output from console.
            DIfferent_IOs.IO_Test Cl_inst_IO_Test = new IO_Test(); //Creating a class instance to access the methods and variables with in the class and the new instace "Cl_inst_IO_Test" is called an object.
            //Cl_inst_IO_Test.SimpleIO(); //calling a method
            //Cl_inst_IO_Test.Diff_WLs(); //calling a method
            

            //Lesson 2: Loops.
            loopsandconi.diff_loops cl_inst_loops = new diff_loops();
            //cl_inst_loops.m_if_loop();
            //cl_inst_loops.m_while_loop();
            //cl_inst_loops.for_loop();
            //cl_inst_loops.m_foreach();
            //cl_inst_loops.switch_condi();
            cl_inst_loops.m_try_catch();

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
            //diff_methods.method_types inst_method = new method_types(); // this class has constructors
            //diff_methods.method_types inst_method2 = new method_types("parameters"); // this class has constructors that takes parameters.
            //inst_method.m1_access_speci_method(); //public
            //inst_method.m2_generic_method(); // private, unable to call private method
            //inst_method.m3_returing_methods(); // void return
            //var v=inst_method.m4_returing_methods(); // with string return type
            //Console.WriteLine("value of k is:"+v);
            //inst_method.m5_pass_parameters(3,5);
            //method_types.m6_static_method(); // here we can access the static methods without creating any objects.
                        
            

        }
    }
}
