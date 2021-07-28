using System;

class Program
{
   
 
public static void Main(String []args)
{
    
     
    Console.WriteLine("Enter the number of Unit Consumed ");
    double units = Convert.ToDouble(Console.ReadLine());
    if (units <= 200)
    {
        Console.WriteLine(units * 2);
    }
    else if (units <= 350)
    {
       Console.WriteLine((200 * 2) +
               (units - 200) * 3);
    }
    else if (units <= 500)
    {
       Console.WriteLine( (200 * 2) +
               (150 * 3) +
               (units - 150) * 5);
    }
    else if (units > 500)
    {
       Console.WriteLine( (200 * 2) +
               (150 * 3) +
               (150 * 5) +
               (units - 500) * 7);
    }
}
    
}