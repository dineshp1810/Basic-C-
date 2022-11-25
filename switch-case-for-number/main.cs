using System;
class switchcase {
  public static void Main()
  {
    int num1,num2,operation,ans;
    Console.WriteLine("1.Addition");
    Console.WriteLine("2.Subtraction");
    Console.WriteLine("3.Multiplication");
    Console.WriteLine("4.Division");
    Console.Write("Enter your choise: ");
    operation=Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter First Number : ");
    num1=Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter Second Number: ");
    num2=Convert.ToInt32(Console.ReadLine());
    
    switch(operation)
    {
        case 1:
            ans=num1+num2;
            Console.WriteLine("Answer Is :"+ans);
            break;
        case 2:
            ans=num1-num2;
            Console.WriteLine("Answer Is :"+ans);
            break;
        case 3:
            ans=num1*num2;
            Console.WriteLine("Answer Is :"+ans);
            break;
        case 4:
            ans=num1/num2;
            Console.WriteLine("Answer Is :"+ans);
            break;
        default:
            Console.WriteLine("Enter The Valid Chiose");
            break;
            
    }
  }
}