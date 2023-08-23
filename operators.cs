/*
    Overview
    Arithmetic operators: +,-,*,/,%
    Boolean logical operators: (AND) &&, (OR) ||, (Not) !, 
    Bitwise and shift operators (Ignore)
    Equality operators and  Comparison operators: ==,!=,<,>,
    Member access operators and expressions: . , ->
    Type-testing operators and cast expression: is, as, typeof, gettype
    User-defined conversion operators 
    Pointer-related operators &, *, ++, --, fixed 
    Assignment operators: =, +=, -=, *=, etc
    Lambda expressions: Parameter List, Operator(=>), Body
    Patterns: Type(is), Property(when), Tuple, switch statment and pattern, 
    is operator  
    
    null-coalescing ?? and ??= operators and default value expressions
    
    qualifier :: operator
    await operator
    
    nameof expression
    
    
    stackalloc expression
    switch expression
    true and false operators
    with expression
    Operator overloading
*/
using System;
namespace diff_operators;

class many_operators{
    public void m1_turnary_op(){ //?: operator or turanry ope used instaed of if statment
        Console.Write("Is it a good day?(y)");
        string v=Console.ReadLine();
        string op = v=="y" ? "good day" : "that bad";

        Console.Write("So, {0} uh.",op);


    }
}
