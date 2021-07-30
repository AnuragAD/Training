using System;

class Multiplication
{
   
 
public static void Main(String []args)
{
     Console.WriteLine("Enter your any number: ");
     int num = Convert.ToInt32(Console.ReadLine());
     for(int i = 1; i<=20; i++)
     {
       Console.WriteLine("{0}*{1}={2}",num,i,num*i);  
     }
}
    
}