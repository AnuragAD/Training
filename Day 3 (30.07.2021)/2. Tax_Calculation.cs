using System;  
  public class VAT 
    {  
       public virtual void CalculateTax(int num) 
        { 
           int Amount  = (num+(num*20)/100);
           Console.WriteLine("Amount after including 20% VAT is {0}",Amount);
        }  
   }  
   public class GST : VAT 
   {  
       public override void CalculateTax(int num) 
        { 
           int Amount  = (num+(num*12)/100);
           Console.WriteLine("Amount after including 12% GST is {0}",Amount); 
        }  
   }  
   class MainClass{  
       public static void Main(string[] args)  
        {  
            VAT vat = new VAT();  
            GST gst = new GST();
            Console.WriteLine("Enter Amount:"); 
         int num = Convert.ToInt32(Console.ReadLine()); 
         
            vat.CalculateTax(num);  
            gst.CalculateTax(num);  
         
        }  
    }  