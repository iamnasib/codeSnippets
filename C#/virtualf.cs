using System;
class abc
{
    public static void Main()
    {
       pqr obj=new pqr();
       obj.fun();
    }
   
}
class xyz
{
     public virtual void fun()
    {
        Console.WriteLine("fun called");
    }
}
class pqr:xyz
{
    public override void fun()
    {
         Console.WriteLine("fun called again");
    }
}