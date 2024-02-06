using System;
class basic
{
    public static void Main()
    {
        basic obj=new basic();
        obj.prop=12;
        Console.WriteLine(obj.prop);
    }
    private int x;
    public  int prop
    {
        
       
        set 
        {
         x=value;
        }
         get
        {
            return x;
        }
    }
}