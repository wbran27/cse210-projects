using System;

public class Blind
{
    //this is what is inside and ready to be stored in the class
  public double _width;
  public double _height;
  public string _color;

public double GetArea()
{
    return _width * _height;
}
public class House
{
    public string _owner;
    public Blind _kitchen;
    public Blind _livingRoom;
    public List<Blind> _blinds = new List<Blind>();

    // public string _owner = "";
    // public Blind _kitchen = new Blind();
    // public Blind _livingRoom = new Blind();
}

}