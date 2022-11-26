using System;
class Decimal 
{
  public int convert(char c)
  {
    if(c.Equals('I'))
       return 1;
    else if(c.Equals('V'))
       return 5;
    else if(c.Equals('X'))
       return 10;
    else if(c.Equals('L'))
       return 50;
    else if(c.Equals('C'))
       return 100;
    else if(c.Equals('D'))
       return 500;
    else if(c.Equals('M'))
       return 1000;
    else
       return-1;
  }
}
public class RomanToDec
{
    public static void Main()
    {
        Console.WriteLine("The Roman Letter Are:I,V,L,C,D,M,X");
        string ch=Console.ReadLine();
        int sum=0,i;
        Decimal dec=new Decimal();
        for(i=0;i<ch.Length;i++)
        {
            sum+=dec.convert(ch[i]);
        }
        Console.WriteLine(sum);
    }
}