/*
    Overview
    Arithmetic operators
    Boolean logical operators
    Bitwise and shift operators
    Equality operators
    Comparison operators
    Member access operators and expressions
    Type-testing operators and cast expression
    User-defined conversion operators
    Pointer-related operators
    Assignment operators
    Lambda expressions
    Patterns
    + and += operators
    - and -= operators
    
    ! (null-forgiving) operator
    ?? and ??= operators
    => operator
    :: operator
    await operator
    default value expressions
    delegate operator
    is operator
    nameof expression
    new operator
    sizeof operator
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
