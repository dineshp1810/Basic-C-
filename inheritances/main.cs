using System;
class father
{
    public void house()
    {
        Console.WriteLine("new house access for his son");
    }
}
class son : father
{
    public void car()
    {
        Console.WriteLine("new car");
    }
}
public class inheritance
{
    public static void Main()
    {
        son o=new son();
        o.car();
        o.house();
    }
}