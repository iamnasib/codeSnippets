using System;
class cal
{
    public static void Main()
    {
        Console.WriteLine("Enter 1st number");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd number");
        int y=Convert.ToInt32(Console.ReadLine());
        cal obj=new cal();
        int add;
        int sub;
        obj.ad(x,y,out add, out sub);
        Console.WriteLine(add);
        Console.WriteLine(sub);
       
    }
    public void ad(int x,int y,out int add,out int sub)
    {
        add=x+y;
        sub=x-y;
 
    }
}