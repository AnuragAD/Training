using System;

class Multiplication
{
   
 
public static void Main(String []args)
{
     Console.WriteLine("Select TV packages Out of below Packages");
     Console.WriteLine("Package A");
     Console.WriteLine("Package B");
     Console.WriteLine("Package C");
  string package = Console.ReadLine();
switch(package)
{
       case "Package A":  Console.WriteLine("Package A Costs Rs 250 and includes: ");
                          Console.WriteLine("South Special");
                          Console.WriteLine("Children's Club");
                          Console.WriteLine("Movies");
                          break;
       case "Package B": 
                          Console.WriteLine("Package B Costs Rs 450 and includes: ");
                          Console.WriteLine("News");
                          Console.WriteLine("Sports");
                          Console.WriteLine("Movies");
                          Console.WriteLine("Regional-2");
                         break;
       case "Package C":
                          Console.WriteLine("Package C Costs Rs 350 and includes: ");
                          Console.WriteLine("Discovery");
                          Console.WriteLine("History, National");
                         break;
       default: Console.WriteLine("Wrong Input Please write correct input");
                          break;
}
}
    
}