using System;
class poly
{
    public static void Main()
    {
         poly obj=new poly();
         obj.fun(2);
         obj.fun(2,3);
    }
    public void fun(int x)
    {
        Console.WriteLine(x);
    }
     public void fun(int x,int y)
    {
        Console.WriteLine(x+y);
    }
}