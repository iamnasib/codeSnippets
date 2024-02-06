using System;
class frst
{
    public static void Main()
    {
    
     thrd o=new thrd();
     o.abc();
     o.walk();
     o.last();
    }
    public void abc()
    {
        Console.WriteLine("abc called");
    }
}
class scnd:frst
{
    public void walk()
    {
       Console.WriteLine("scnd:frst walk called");
    }
}
class thrd:scnd
{
   public void last()
   {
       Console.WriteLine("thrd:scnd last called");
   }
}