using System;
public class Student
    {
       public static void Main(string[] args)
        {
    int[] marks = new int[5];
    float per;
    int total=0;
    string name;

    Console.Write("Enter the name of Student:");
    name = Console.ReadLine();

    Console.Write("Enter the marks for English: ");
    marks[0]= Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the marks for Mathematics: ");
    marks[1]= Convert.ToInt32(Console.ReadLine()); 
 
    Console.Write("Enter the marks for Physics: ");
    marks[2]= Convert.ToInt32(Console.ReadLine());    

    Console.Write("Enter the marks for Chemistry: ");
    marks[3]= Convert.ToInt32(Console.ReadLine()); 

    Console.Write("Enter the marks for Computer Science: ");
    marks[4]= Convert.ToInt32(Console.ReadLine()); 
    for(int i =0; i<5; i++){
        total = total+marks[i]; 
    }
    per = (total*100)/500;
   Console.WriteLine("--------------------------------------------------");
   Console.WriteLine("{0} your Total Score is {1} and Percentage is {2}",name, total,per );
}
}