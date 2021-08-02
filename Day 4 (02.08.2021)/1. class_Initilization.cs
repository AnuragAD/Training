using System;
public class Name
{
private string NAME; 
private int AGE;
public void SetNameAge(String name, int age)
{
   NAME = name;
   AGE = age;
}

public String GetName()
{
      return NAME;
      
}
public int GetAge()
{
      return AGE;
      
}

}


class Initilize
{
public static void Main()
{
Name N = new Name();
N.SetNameAge("Anurag", 23);
String NAME = N.GetName();
int AGE = N.GetAge();
Console.WriteLine($"Your name is {NAME} and your age is {AGE}");
}
}