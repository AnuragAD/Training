using System;
public abstract class Package
{
    public abstract void Accomodation();
    public abstract void food();
}

public class Silver : Package
{
    public override void Accomodation()
    {
        Console.WriteLine("Three days Accomodation at Resort");
    }
    public override void food()
    {
        Console.WriteLine("Includes No food");
    }
}

public class Gold : Package
{
    public override void Accomodation()
    {
        Console.WriteLine("5 days Accomodation at Resort");
    }
    public override void food()
    {
        Console.WriteLine("Includes 2 dinner in the house");
    }
}

public class Platinum : Package
{
    public override void Accomodation()
    {
        Console.WriteLine("7 days Accomodation at Resort");
    }
    public override void food()
    {
        Console.WriteLine("Includes 5 dinner in the house");
    }
}

class AbsProg
{
    public static void Main()
    {
        Console.WriteLine("Choose Member package from following: ");
        Console.WriteLine("Press 1 for Silver Package");
        Console.WriteLine("Press 2 for Gold Package");
        Console.WriteLine("Press 3 for Platinum Package ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1": Console.WriteLine("Silver Package has: ");
                      Silver S = new Silver();
                      S.Accomodation();
                      S.food();
                      Console.ReadLine();
                      break;
            case "2":
                Console.WriteLine("Gold Package has: ");
                Gold G = new Gold();
                G.Accomodation();
                G.food();
                Console.ReadLine();
                break;
            case "3":
                Console.WriteLine("Platinum Package has: ");
                Platinum P = new Platinum();
                P.Accomodation();
                P.food();
                Console.ReadLine();
                break;

             default : Console.WriteLine("Wrong Choice");
                             Console.ReadLine();
                break;
        }
    }
}