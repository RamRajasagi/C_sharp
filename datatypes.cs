using System;

namespace datatypes{
    class dtype{
        public  void m1(){
            var v = 25; // var data type can be anything based on the input. this is int
            var v1="second var example";// this is string
            bool b1= true; // Boolean can be only true or false no other value. not ever 0 or 1
            int j = 53; // integral datatype others include : sbyte, byte, short, ushirt, uint, long, ulong, BigInteger( as name suggest for big ints) and some times char. u* dataype can hold only positive numbers  
            float k = 5.3f; // float datatype, it should always end with f its not that precise after some decimal points. 
            double d = 5.363; // double is an other float datatype, similarly with have decimal as well for high decimal values
            decimal de= 5.363m; // decimal is a datatype which is used for high precision decimal values. and it should end with m when you are directly assigning a value to it.
            string s = "Camera";
            string lit = @"not in next line \n its in the same line as its declared as a verbatim literal";
            DateTime dt = DateTime.Now; // DateTime is a datatype which is used to store date and time.
            DateOnly d1 = DateOnly.FromDateTime(DateTime.Now); // DateOnly is a datatype which is used to store only date.
            TimeOnly t1 = TimeOnly.FromDateTime(DateTime.Now); // TimeOnly is a datatype which is used to store only time.
            Console.WriteLine($"these are different data types \n boolean: {b1} \n integer: {j} \n float: {k} \n double: {d} \n decimal: {de} \n string: {s} \n Literal String: {lit} \n Date Time: {dt} \n Date: {d1} \n Time: {t1} \n var data type: {v} and {v1}");

            // Parsing examples
            string s1 = "25";
            int i = int.Parse(s1); // int.Parse is used to convert string to int
            string s2 = j.ToString(); // int.ToString is used to convert int to string
            Console.WriteLine($"Parsing examples \n string to int: {i} \n int to string: {s2}");

            // TryParse examples
            string s3 = "25";
            int i1;
            bool b = int.TryParse(s3, out i1); // int.TryParse is used to convert string to int, but it will not throw an exception if the conversion fails, instead it will return a boolean value
            Console.WriteLine($"TryParse examples \n string to int: {i1} \n Conversion success: {b}");

            // Nullable types
            int? ni = null; // nullable types are used to store null values in a variable
            Console.WriteLine($"Nullable types \n Nullable int: {ni}");

            // Constants
            const int c = 25; // Constants are used to store values which are not supposed to be changed
            Console.WriteLine($"Constants \n Constant int: {c}");
            
        }
    }
}