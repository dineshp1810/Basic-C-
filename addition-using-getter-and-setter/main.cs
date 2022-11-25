using System;
class Addition
{
    private int num1,num2;
    public int NUM1 
    {
      get 
      { 
          return num1; 
      }
      set 
      { 
          num1 = value; 
      }
    }
    public int NUM2
    {
      get 
      { 
          return num2; 
      }
      set 
      { 
          num2 = value; 
      }
    }
    public int sum()
    {
       int ans=num1+num2;
       return ans;
    }
}

class Add
{
  public static void Main()
  {
      Addition myObj = new Addition();
      myObj.NUM1 =Convert.ToInt32(Console.ReadLine());
      myObj.NUM2 =Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(myObj.sum());
    
  }
}