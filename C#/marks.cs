using System;
class Nasib
{
    public static void Main()
    {
        Console.WriteLine("Enter your Name");
        string names=Console.ReadLine();
        Console.WriteLine("Welcome "+names);
        Console.WriteLine("Enter The Marks of English");
        double number=Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter The Marks of Urdu ");
        double no=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Marks of Math ");
        double Math=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Marks of Science");
        double sci=Convert.ToDouble(Console.ReadLine());
    
        Console.WriteLine("Enter The Marks of SST ");
        double ss=Convert.ToDouble(Console.ReadLine());
        double a=number;
        double b=no;
        
        double d=Math;
        double e=sci;
        double f=ss;
        double g=a+b+d+e+f;
        double MM=500;
        Console.WriteLine("Your Total Marks Are "+g);
        Console.WriteLine("Your Percentage is "+g/MM*100);
        
        
    }
}