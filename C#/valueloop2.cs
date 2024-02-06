using System;
class value
{
    public static void Main()
    {
        int[] value=new int[5];
        value[0]=100;
        value[1]=200;
        value[2]=300;
        value[3]=400;
        value[4]=500;
        Console.WriteLine("enter the value");
        int va=Convert.ToInt32(Console.ReadLine());
        for(int i=0; i<=4; i++)
       {
       switch(va)
       
       {
           case i:
           Console.WriteLine("The value exists");
           break;
       
       default:
       
            Console.WriteLine("The value doesn't exists");
            break;
       }
       
       }
    }
}