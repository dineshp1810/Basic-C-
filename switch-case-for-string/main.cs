using System;
class switchcase {
  public static void Main()
  {
    string day;
    Console.WriteLine("Days For This Week :");
    Console.WriteLine("1.sunday");
    Console.WriteLine("2.monday");
    Console.WriteLine("3.tuesday");
    Console.WriteLine("4.wednesday");
    Console.WriteLine("5.thursday");
    Console.WriteLine("6.friday");
    Console.WriteLine("7.saturday");
    Console.Write("Enter The day for aboue formate : ");
    day=Console.ReadLine();
    switch(day)
    {
        case "monday":
            Console.WriteLine("First day of the week.Enjoy you day....");
            break;
        case "tuesday":
            Console.WriteLine("Second day of the week.Enjoy you day....");
            break;
        case "wednesday":
            Console.WriteLine("Third day of the week.Enjoy you day....");
            break;
        case "thursday":
            Console.WriteLine("Fourth day of the week.Enjoy you day....");
            break;
        case "friday":
            Console.WriteLine("Fifth day of the week.Enjoy you day....");
            break;
        case "saturday":
            Console.WriteLine("Six day of the week.Enjoy you day....");
            break;
        case "sunday":
            Console.WriteLine("Weekend for all.Enjoy you holidy.....");
            break;
        default:
            Console.WriteLine("Enter The Valid day");
            break;
            
    }
  }
}
