using System;
using System.Collections.Generic;
class Create_list 
{
  public static void Main() 
  {
    var name=new List<string>();
    Console.Write("How many members you want add:");
    int i,num=Convert.ToInt32(Console.ReadLine());
    for(i=0;i<num;i++)
    {
        name.Add(Console.ReadLine());
    }
    int co=name.Count;
    for(i=0;i<co;i++)
    {
        Console.WriteLine(name[i]);
    }
  }
}