using System;

namespace DIfferent_IOs{
    class IO_Test{
        public void SimpleIO(){
            Console.WriteLine("Enter Name:");
            var Name=Console.ReadLine();
            Console.WriteLine("Name:"+Name);
        }

        public void Diff_WLs(){
            string wls="one way to console op";
            int i=123;
            Console.WriteLine("Hello this is + output style: "+wls);
            Console.WriteLine("Hello this is string format operation style: {0}", wls);
            //working with two or more ints.
            Console.WriteLine("Hello this is + output style: "+wls+" and this way we can add 2nd var: "+i);
            Console.WriteLine("Hello this is string format operation style: {0} and this way we can add 2nd var {1}", wls,i);
            //string interpolation
            System.Console.WriteLine($"Hello this is string interpolation style: {wls} and this way we can add 2nd var {i}");
        }       

    }   
}
