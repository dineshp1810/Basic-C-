using System;
class Encapsulation
{
    private int length;
    private int width;
    public int Getvalue()
    {
        length=Convert.ToInt32(Console.ReadLine());
         width=Convert.ToInt32(Console.ReadLine());
         return 0;
    }
    public int Area()
    {
        return length*width;
    }
    public void Display()
    {
        Console.WriteLine("length:{0}",length);
        Console.WriteLine("width:{0}",width);
        Console.WriteLine(Area());
    }
}
class Maincode
{
    public static void Main(string[] args)
    {
      Encapsulation obj=new Encapsulation();
      obj.Getvalue();
      obj.Display();
    }
}