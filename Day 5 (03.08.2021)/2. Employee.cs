using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    [Serializable]
    class Employee
    {
        int Id;
        String Name;
        String Gender;
        int age;
        public static void Main()
        {
            Employee obj = new Employee();
            obj.Id = 1;
            obj.Name = "Anurag";
            obj.Gender = "Male";
            obj.age = 23;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"E:/Training/Day 5/files/employee.txt", FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"E:/Training/Day 5/files/employee.txt", FileMode.Open, FileAccess.Read);
            Employee objnew = (Employee)formatter.Deserialize(stream);
            Console.WriteLine(objnew.Id);
            Console.WriteLine(objnew.Name);
            Console.WriteLine(objnew.Gender);
            Console.WriteLine(objnew.age);
            Console.ReadKey();
           
        }
    }
}


















//Console.WriteLine("Enter Employee Id: ");
//int id = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Employee Name: ");
//string name = Console.ReadLine();
//Console.WriteLine("Enter Employee Gender: ");
//string gender = Console.ReadLine();
//Console.WriteLine("Enter Employee Age: ");
//int age = Convert.ToInt32(Console.ReadLine());
//ArrayList AL = new ArrayList();
//AL.Add(id);
//AL.Add(name);
//AL.Add(gender);
//AL.Add(age);
//Employee sobj = new Employee();