using System;
class op
{
    public static void Main()
    {
      oper obj1=new oper(10);
      oper obj2=new oper(20);
     if(obj1==obj2)
     {
         Console.WriteLine("equal");
     }
     else
     {
       Console.WriteLine("no");
     }

    }
}
class oper
{
    public int first;
    public oper(int x)
    {
        first=x;
    }
    public static bool operator==(oper obj1,oper obj2)
     {
        return obj1.first==obj2.first;
     }
     public static bool operator!=(oper obj1,oper obj2)
    {
        return obj1.first!=obj2.first;
    }   
}
