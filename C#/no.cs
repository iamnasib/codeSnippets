using System;
class Nasib
{
    public static void Main()
    {
        Console.WriteLine("Enter your Name");
        string names=Console.ReadLine();
        Console.WriteLine("Welcome "+names);
        Console.WriteLine("Enter The Number");
        double number=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The second Number ");
        double no=Convert.ToDouble(Console.ReadLine());
        double a=number;
        double b=no;
        double c=a+b;
        double d=a-b;
        double e=a*b;
        double f=a/b;
        Console.WriteLine("The addition of two nmbrs is "+c);
        Console.WriteLine("The subtraction of two nmbrs is "+d);
        Console.WriteLine("The multiplication of two nmbrs is "+e);
        Console.WriteLine("The division of two nmbrs is "+f);
    }
}