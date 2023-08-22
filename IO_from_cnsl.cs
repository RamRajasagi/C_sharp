//Lesson 1
using System;

namespace DIfferent_IOs{
    class IO_Test{
        public void SimpleIO(){
            Console.Write("Enter Name:"); // use double qoutes always
            var Name=Console.ReadLine();
            Console.WriteLine("Name:"+Name); // WriteLine prints data in next line. Write prints it in same line
        }

        public void Diff_WLs(){
            string var1="my variable"; // use double qoutes always
            int i=123;
            Console.WriteLine("Hello this is + output style: "+var1);
            Console.WriteLine("Hello this is string format operation style: {0}", var1);
            //working with two or more ints.
            Console.WriteLine("Hello this is + output style: "+var1+" and this way we can add 2nd var: "+i);
            Console.WriteLine("Hello this is string format operation style: {0} and this way we can add 2nd var {1}", var1,i);
            //string interpolation
            System.Console.WriteLine($"Hello this is string interpolation style: {var1} and this way we can add 2nd var {i}"); // this is the style we want to use. 
        }       

    }   
}
