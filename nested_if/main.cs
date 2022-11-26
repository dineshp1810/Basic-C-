using System;
class nested_if
{
  public static void Main() 
  {
    Console.WriteLine("Find the larget of three number");
    int num1,num2,num3;
    num1=Convert.ToInt32(Console.ReadLine());
    num2=Convert.ToInt32(Console.ReadLine());
    num3=Convert.ToInt32(Console.ReadLine());
    if(num1>num2)
    {
        if(num1>num3)
        {
            Console.WriteLine(num1+"is the larget number");
        }
        else
        {
            Console.WriteLine(num3+"is the larget number");
        }
    }
    else if(num2>num3)
    {
       Console.WriteLine(num2+"is the larget number");   
    }
    else
    {
        Console.WriteLine(num3+"is the larget number");
    }
  }
}
