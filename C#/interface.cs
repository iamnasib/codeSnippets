using System;
class thrd:scnd,frst
{
    public static void Main()
    {
        thrd obj=new thrd();
        obj.abc();
        obj.walk();
    }
   public void abc()
   {
       Console.WriteLine("interface frst called abc");
   }
   public void walk()
    {
      Console.WriteLine("interface scnd called walk");
    }
    }

   

interface frst
{
   
     void abc();
   
}
interface scnd
{
    void walk();
    
}
