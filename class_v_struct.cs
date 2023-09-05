//Class vs Struct
// pass by value and pass by reference

using System;

namespace cvs;

// Define a class
public class PersonClass
{
    public string Name { get; set; } // declaring name proerties
    public int Age { get; set; }

    public PersonClass(string name, int age) // creating class contructor
    {
        Name = name;
        Age = age;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Define a struct
// structs cant have destructors, cant have defined constructors without paramets, cant inherit from classes but can inherit from onterfaces. 
public struct PersonStruct
{
    public string Name { get; set; }
    public int Age { get; set; }

    public PersonStruct(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

