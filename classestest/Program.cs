using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("He");
        Messages.Hello();
        Messages.Waiting();
        // make a human using human class 
        Human human1 = new Human();
        // give the name and age
        human1.name = "Brandon";
        human1.age = 65;
        human1.eat();
        human1.sleep();
        
        //make a new human using the same class
        Human human2 = new Human();
        human2.name = "Hank";
        human2.age = 25;
        human2.eat();
        human2.sleep();
    }
}   

class Human
{
    public String name;
    public int age;

    public void eat()
    {
        Console.WriteLine(name + " is eating");
    }
    public void sleep()
    {
        Console.WriteLine(name + " is sleeping");
    }
}

