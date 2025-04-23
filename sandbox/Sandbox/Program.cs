using System;

class Program
{
    static void Main(string[] args)
    {
        // this is a program to compute radius from a circle.

        // get radius
        Console.Write("please enter the radius: ");
        string text = Console.ReadLine();
        // convert string into double (integer)
        double radius = double.Parse(text);

        // compute are of the circle
        double area = Math.PI * radius * radius;

        // display area of user to see
        Console.WriteLine($"area of the circle {area}");
        
        int x = 3;
        string s = "sup";
        float f = 3.14F;
        double d = 5.21;
        // $ works like f like in python 
        Console.WriteLine($"Hello, {s} Sandbox World! {x} {f} {d}");
    }
}