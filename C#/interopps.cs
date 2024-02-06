using System;
class interoop
{
    public static void Main()
    {
        add();
    }
    public static void add()
    {
        Console.WriteLine("enter 1st nmbr");
        int ad=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter 2nd nmbr");
        int ad2=Convert.ToInt32(Console.ReadLine());
       int a=ad+ad2;
        Console.WriteLine(a);

    }
}