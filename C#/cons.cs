using System;
class cons
{
    public static void Main()
    {
        cons obj=new cons();
        obj.abc();
    }
    public void abc()
    {
        Console.WriteLine("abc called");
    }
    public cons()
    {
        Console.WriteLine("constructer called");
    }

}