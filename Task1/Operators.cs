using System;

namespace Task1;

public class Operators
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void Subtract(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    public void Multiply(int a, int b)
    {
        Console.WriteLine(a * b);
    }
    public void Divide(int a, int b)
    {
        Console.WriteLine(a / b);
    }
    public void OddEvenFinder(int number)
    {
        string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
        Console.WriteLine(result);
    }

}