using System;
public class Myclass
{
  
    public void Method1()=>Console.WriteLine("method1");
    public void Method2()=>Console.WriteLine("method2");
  
}
class Maincode
{
    public static void Main()
    {
        Myclass obj=new Myclass();
        obj.Method1();
        obj.Method2();
        obj.Method3();
    }
}
public static class Extendedclass
{
    public static void Method3(this Myclass obj)
    {
        Console.WriteLine("Extendedclass Method3");
    }
}