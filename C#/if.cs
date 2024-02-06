using System;
class Nasib
{
    public static void Main()
    {
        Console.WriteLine("Enter your Name");
        string names=Console.ReadLine();
        Console.WriteLine("Welcome "+names);
        Console.WriteLine("Enter The Marks of English MM" +100);
        double number=Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter The Marks of Physics MM" +100);
        double no=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Marks of Chemistry MM" +100);
        double Math=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Marks of Biology MM" +100);
        double sci=Convert.ToDouble(Console.ReadLine());
    
        Console.WriteLine("Enter The Marks of IP MM" +100);
        double ss=Convert.ToDouble(Console.ReadLine());
        double a=number;
        double b=no;
        
        double d=Math;
        double e=sci;
        double f=ss;
        double g=a+b+d+e+f;
        double MM=500;
        double p=g/MM*100;
        Console.WriteLine("Your Total Marks Are "+g);
        Console.WriteLine("Your Percentage is "+p);
        if (p > 50)
        {
            Console.WriteLine("You are promoted");
        }
        else
        {
            Console.WriteLine("Failed");
        }
        
        
    }
}