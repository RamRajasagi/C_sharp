// Exception handling - try catch finally block
// read or write to a file
//types of exceptions
// we can also create a custom exception

using System;
using System.IO;

namespace exc_hand
{

    class ex_handle{
        public void reading(){
            StreamReader read=null; // StreamReader helps reading data from a file syntax simmer to class StreamReader x= new StreamReader(path to get a file)
            try{
            read = new StreamReader(@"C:\Users\rrajasagi\Documents\GITHUB\Personal\C_sharp\read me.txt"); // from previous class @ says when the values in here are literal value.
            }
            catch(Exception ex){ // there are several types of exceptions but for all the base class is "Exception"
                Console.WriteLine(ex.Message);

            }
            finally{ // finally block works after all the try catch blocks are done. even if the catch blocks are not executed. best used to clean resources
            Console.WriteLine(read.ReadToEnd());
            read.Close();
            }
        }

        public void writing(){
            StreamWriter write=null;
            string l = "test data just delete";

            try{
                write = new StreamWriter(@"C:\Users\rrajasagi\Desktop\test.txt"); //similar to reader style and is the file doesn't exist it will crate the file in the specified folder path.   
                write.Write(l);  // this is how we write the data
                
            }
            catch(Exception ex){
                Console.WriteLine("the path doesn't exist");
                Console.WriteLine(ex.Message);
            }
            finally {
                write.Close();
            }

        }
    }

}

/* these are some common exceptions 
In C#, exceptions are objects that represent error conditions during program execution. There are several major types of exceptions in C#:
1. **System.Exception**:
   - This is the base class for all exceptions in C#. It provides properties like `Message`, `StackTrace`, and `InnerException` which are common to all exceptions.

2. **System.SystemException**:
   - This is a subclass of `Exception`. It serves as the base class for all runtime exceptions in the .NET Framework.

3. **System.ApplicationException**:
   - This class is also derived from `SystemException`. In practice, it is not widely used directly. Instead, custom exceptions are usually derived from `SystemException` or directly from `Exception`.

4. **System.ArithmeticException**:
   - This is a subclass of `SystemException`. It represents errors that occur during arithmetic operations, such as divide-by-zero.

5. **System.IndexOutOfRangeException**:
   - This is a subclass of `SystemException`. It is thrown when an attempt is made to access an array element with an index that is outside the bounds of the array.

6. **System.NullReferenceException**:
   - This is a subclass of `SystemException`. It is thrown when a program attempts to use an object reference that has not been initialized (i.e., it's `null`).

7. **System.InvalidCastException**:
   - This is a subclass of `SystemException`. It is thrown when an invalid cast is made between incompatible types.

8. **System.ArgumentException**:
   - This is a subclass of `SystemException`. It is thrown when an argument provided to a method is not valid.

9. **System.IO.IOException**:
   - This is a subclass of `SystemException`. It is thrown when an I/O error occurs.

10. **System.FileNotFoundException**:
   - This is a subclass of `IOException`. It is thrown when an attempt to access a file fails because the file cannot be found.

11. **System.FormatException**:
   - This is a subclass of `SystemException`. It is thrown when a format of an argument is invalid.

12. **System.OutOfMemoryException**:
   - This is a subclass of `SystemException`. It is thrown when the system is out of memory.

13. **System.StackOverflowException**:
   - This is a subclass of `SystemException`. It is thrown when the execution stack overflows due to too many method calls being pushed onto the stack.

These are some of the major types of exceptions in C#. Remember, you can also create custom exceptions by inheriting from existing exception classes or directly from `Exception`. This allows you to create specialized exception types tailored to your application's needs.
*/