using System;
using Task1;
public class Program
{
    public static void Main(string[] args)
    {
        Operators op = new Operators();

        op.Add(25, 50);
        op.Subtract(60, 51);
        op.Multiply(9, 5);
        op.Divide(100, 5);
        op.OddEvenFinder(8);
    }
}