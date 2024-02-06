using System;
class nasib
{
    public static void Main()
    {
        Console.WriteLine("Enter the grade");
        char grade=Convert.ToChar(Console.ReadLine());
        switch (grade)
        {
            case 'a':
        Console.WriteLine("Exellent");
        break;
        case 'b':
        Console.WriteLine("Good");
        break;
        case 'c':
        Console.WriteLine("bad");
        break;
        case 'd':
        Console.WriteLine("poor");
        break;
        default:
        Console.WriteLine("Invalid grade");
        break;
        }
        
    }
}