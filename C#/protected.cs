using System;
class pro
{
    protected void abc()
    {
        Console.WriteLine("2");
    }
}
class ma:pro
{
    public static void Main()
    {
        ma obj=new ma();
        obj.abc();
    }
}