/*
    Overview
    Arithmetic operators: +,-,*,/,%
    Assignment operators: =, +=, -=, *=, etc
    Boolean logical operators: works with only Boolean data type (true , false): (AND) &&, (OR) ||, (Not) !, 
    Bitwise and shift operators (Ignore)
    Equality operators and  Comparison operators: ==,!=,<,>,etc
    Member access operators (to access members (fields, properties, methods, events, etc.) ): . 
    Type-testing operators and cast expression: is: is operator checks if an object is of a certain type or is compatible with a specific type.,
     as: this performs a safe type conversion (cast) of an object to a specific type., 
     typeof, gettype: to get type of the object
    null-coalescing ?? and ??= operators and default value expressions

   

not covered topics:
    qualifier :: operator
    await operator
    stackalloc expression (used to allocate a block of memory on the stack rather than the heap)
    nameof expression
    with expression
    Operator overloading
    Unsafe code operators (not commanly used)
    pointers:  ->, int*, char*, double*, etc.,
    Pointer-related operators &, *, ++, --, fixed 
    Patterns: Type(is), Property(when), Tuple, switch statment(switch expression advanced) and pattern, 
    Lambda expressions: Parameter List, Operator(=>), Body (more info in Linq chapter)
*/
using System;
namespace diff_operators;

class many_operators
{
    public void m1_turnary_op()
    { //?: operator or turanry ope used instaed of if statment
      // for this to wiork you need 1. Condition: There should be a condition that determines whether the value returned is 50 or 80. 
      // 2. Assignment: The result of the expression should be assigned to a variable or used in some way.
        Console.Write("Is it a good day?(y)");
        string v = Console.ReadLine();
        string op = v == "y" ? "good day" : "that bad"; // v=="y" is condition and op is assigment. 

        Console.Write("So, {0} uh.", op);
    }

    public void ABC_method()
    {
        int i = 5;
        int j = 10;
        bool b = true;
        bool l = false;
        Console.WriteLine($" Sum: {i + j} \n Sub: {j - i} \n multiply: {i * j} \n div_rem: {i / j} \n div_qu: {i % j} ");
        Console.WriteLine($" And: {b && l} \n Or: {b || l} \n Not: {b != l}");
        Console.WriteLine($" equal check: {i == j} \n other checks: {i < j} {i > j} {i <= j} {i >= j}");
        System.Console.WriteLine("Calling a methods using the dot operator ex: System.Console.WriteLine ");
    }

}

// example of is operator
class Animal { } // this is base class
class Dog : Animal { } //class Cat : Animal { } class Cow : Animal { }
// this is a dog class inherting base class animal
class animal_check // this class has a method that checks with dog is inherting animal class.
{
    public static void CheckAnimalType(Animal animal)
    {
        if (animal is Dog) // is dog is a aprt of animal then this part runs, else no
        { Console.WriteLine("It's a dog!"); }
        else { Console.WriteLine("It's an unknown animal."); }
    }

}

class nulling
{
    // there are two type of data 1. value type: int, float, decimal, etc. 2. refernce type: class, string, array etc
    // reference type data can be null values, avlue type cant be.
    public static void nullby()
    {
        int j = 0; // defalt to zero for refernce data type
        int? k = null;//  if you want to store null into int the use '?'
        bool? b = null;
        Console.WriteLine($"{k}");//this will not return anything
        Console.WriteLine($"{b}");//this will not return anything
        j = k ?? 10; // this checks if k is null, if null then it assigns a value of 10. as j is int it cant hold a null type so there need to be a value
        Console.WriteLine($"{j}");
    }
}

class conversion
{
    public static void convert()
    {
        float k = 24.23f;
        int i = (int)k; // explicit conversion
        int j = Convert.ToInt32(k); //explicit conversion when handling large numbers
        string s = "24";
        int t =int.Parse(s); // we use this if we are sure that it is an int
        string m = "11";
        int l = 0;
        int.TryParse(m, out l); // we are not sure if we are dealing with an string int. and the return type of tryparse is boolean
        Console.WriteLine($"{i},{j},{t},{l}");
    }
}

