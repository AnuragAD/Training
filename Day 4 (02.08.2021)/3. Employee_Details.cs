using System;

public class Bonus
{
    public string Department;
    public double Salary;
    public void calculate_Bonus(string Department, double salary)
    {
        if (Department == "SalesAndMarketing")
        {
            Salary = salary + 0.2 * salary;
            Console.WriteLine($" Employee Salary is:{Salary} (Bonus Applicable = 20%) ");
        }
       else if (Department == "Production")
        {
            Salary = salary + 0.1 * salary;
            Console.WriteLine($" Employee Salary is:{Salary} (Bonus Applicable = 10%) ");
        }

        else
        {
            Console.WriteLine($" Employee Salary is: {salary} (No Bonus Applicable) ");
        }
    }
}

class Employee : Bonus
{
    public static void Main()
    {
        int id;
        string name;
        string gender;
        int exp;
        double salary;
        string dept;
        Console.WriteLine("Enter Employe Id :");
        id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Employe Name :");
        name = Console.ReadLine();

        Console.WriteLine("Enter Employe Gender :");
        gender = Console.ReadLine();

        Console.WriteLine("Enter Employee experience in years :");
        exp = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Employee Salary: ");
        salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Employee Department :");
        dept  = Console.ReadLine();
        Bonus B = new Bonus();
        B.calculate_Bonus(dept, salary);

        Console.WriteLine($"Employee id is :{id}");
        Console.WriteLine($"Employee name is :{name}");
        Console.WriteLine($"Employee gender is :{gender}");
        Console.WriteLine($"Employee department is :{dept}");
        Console.WriteLine($"Employee experience is :{exp}");
        Console.ReadLine();
    }
}