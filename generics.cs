// this is used when we have a generic(no particular datatype ) input may be int or string to be handled.
//create classes, interfaces, methods and variables that can work with any data type. 
using System;

namespace genrick
{
    public class MyGenericClass<T>//<T> is called type. we add this to make is a generic object. 
    {
        private T genericMemberVariable; // this is a generic variable.

        public MyGenericClass(T value) //constructor that takes a generic value, and the parameter is of type T  
        {
            genericMemberVariable = value;
        }

        public void PrintGenericValue()
        {
            Console.WriteLine("The value stored in the generic member is: " + genericMemberVariable);
        }
    }
}

