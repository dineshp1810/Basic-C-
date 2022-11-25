using System;
 class Palinrome {
  public static void Main() 
  {
    string m="",n=Console.ReadLine();
    int i;
    for(i=(n.Length-1);i>=0;i--)
    {
        m+=n[i];
    }
    if(n==m)
      Console.WriteLine("Palinrome");
    else
      Console.WriteLine("Not a Palinrome");
  }
}
