using System;

namespace datatypes{
    class dtype{
        public  void m1(){
            bool b1= true; // Boolean can be only true or false no other value. not ever 0 or 1
            int j = 53; // integral datatype others include : sbyte, byte, short, ushirt, uint, long, ulong, BigInteger( as name suggest for big ints) and some times char. u* dataype can hold only positive numbers  
            float k = 5.3f; // float datatype, it should always end with f its not that precise after some decimal points. 
            double d = 5.363; // double is an other float datatype, similarly with have decimal as well for high decimal values
            string s = "Camera";
            string lit = @"not in next line \n its in the same line as its decalred as a verbatum literal";
            Console.WriteLine($"these are different data types \n booloean: {b1} \n integer: {j} \n float: {k} \n double: {d} \n string: {s} \n Literal String: {lit}");


        }
    }
}