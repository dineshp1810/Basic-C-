using System;
class Rectangle
{
    int width,length;
    public void getdetails(int x,int y)
    {
        length=x;
        width=y;
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
          Console.Write("length:");
          int length=Convert.ToInt32(Console.ReadLine());
          Console.Write("width:");
          int width=Convert.ToInt32(Console.ReadLine());
          o1.getdetails(length,width);
          Console.WriteLine("Area of Rectangle is:"+o1.area());
    }
}
