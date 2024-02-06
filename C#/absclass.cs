using System;
class abs
{
    public static void Main()
    {
       define obj=new define();
    obj.fun();
    }
}
abstract class basics 
{
    public abstract void fun();
}
class define:basics
{
    
    public override void  fun()
    {
        Console.WriteLine("fun called");
    }
    


}