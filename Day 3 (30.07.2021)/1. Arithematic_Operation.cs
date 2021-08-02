using System;  
   public class AddSubtract 
    {  
       public void addsub(int num1, int num2) 
        { 
           int Sum = num1+num2;
           int Diff = num1-num2;
           Console.WriteLine("Sum of {0} and {1} is {2}",num1,num2,Sum); 
           Console.WriteLine("Difference of {0} and {1} is {2}",num1,num2,Diff); 
        }  
   }  
   public class MultiplyDivide : AddSubtract  
   {  
       public void multiDivide(int num1, int num2) 
        { 
           int Multiply = num1*num2;
           int Divide = num1/num2;
           Console.WriteLine("Multiplication of {0} and {1} is {2}",num1,num2,Multiply); 
           Console.WriteLine("Division of {0} and {1} is {2}",num1,num2, Divide); 
        }  
   }  
   class MainClass{  
       public static void Main(string[] args)  
        {  
            MultiplyDivide d1 = new MultiplyDivide();  
            Console.WriteLine("Enter two numbers:"); 
         int num1 = Convert.ToInt32(Console.ReadLine()); 
         int num2 = Convert.ToInt32(Console.ReadLine()); 
            d1.addsub(num1,num2);  
            d1.multiDivide(num1,num2);  
        }  
    }  