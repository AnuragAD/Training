using System; 
class Jarray
{
public static void Main()
{
String [][] Product = new String[3][];
Product[0] = new String[4]{"GoodDay","Marie","Parle-G","Top-10"};
Product[1] = new String[5]{"DaryMilk","Kaccha_Mango", "Munch","Ecliars","Lollipop"};
Product[2] = new String[6]{"Pepsi","Mountain dew","Mirinda","CocaCOla","Fenta","Mango Shake"};
for(int i =0;i<Product.Length;i++)
{
	for(int j=0;j<Product[i].Length;j++)
	Console.Write(Product[i][j] +"\t");
Console.WriteLine();
}

}
}