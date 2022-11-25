using System;
class Rectangle
{
    int width,length;
    public void getdetails()
    {
        Console.Write("length:");
        length=Convert.ToInt32(Console.ReadLine());
        Console.Write("width:");
        width=Convert.ToInt32(Console.ReadLine());
    }
    public int area()
    {
        int area=length*width;
        return area;
    }
} 
public class class_object
{
    public static void Main(string[] args)
    {
          Console.WriteLine("Find the area of Rectangle");
          Rectangle o1=new Rectangle();
          o1.getdetails();
          Console.WriteLine("Area of Rectangle is:"+o1.area());
    }
}
