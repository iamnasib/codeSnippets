using System;
class loop2
{
    public static void Main()
    {
        int count=0;
        Console.WriteLine("Enter the number of which you want the multiplication table");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Multiplication table is");
        for(int i=a; i<=a*10; i=i+a)
        {
            count=count+1;
            Console.WriteLine(a+" * "+count + " = " + i );
        }
    }
}