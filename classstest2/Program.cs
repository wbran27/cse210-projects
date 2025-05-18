using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        
        Person person1 = new Person();
        person1._givenName = "Joseph";
        person1._familyName = "Smith";
        person1.ShowWesternName();
        person1.ShowEasternName();

        Person person2 = new Person();
        person2._givenName = "brandon";
        person2._familyName = "Gomez";
        person2.ShowWesternName();
        person2.ShowEasternName();
        // setting and putting what is going to be in each variable in the class
        Blind kitchen = new Blind();
        kitchen._width = 60;
        kitchen._height = 48;
        kitchen._color = "white";
        Console.WriteLine(kitchen._width);
        double materialAmount = kitchen.GetArea();
        Console.WriteLine(kitchen.GetArea)
        //another way
        House johnsonHome = new House();
        johnsonHome._kitchen = new Blind();
        johnsonHome._livingRoom = new Bind();
        johnsonHome._owner = "Johnson Family";
        johnsonHome._kitchen._width = 60;

        johnsonHome._blinds.Add(kitchen);
        

    }
}

    // A code template for the category of things known as Person. The
    // responsibility of a Person is to hold and display personal information.
    public class Person
    {
        // The C# convention is to start member variables with an underscore _
        public string _givenName;
        public string _familyName;

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Person()
        {
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }

        // A method that displays the person's full name as used in western 
        // countries or <given name family name>.
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }
    }
    