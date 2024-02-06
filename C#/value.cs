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
        if(va==value[0] || va==value[1] || va==value[2] || va==value[3] || va==value[4])
        {
            Console.WriteLine(" the value exists");
        }
        else
        {
            Console.WriteLine("The value doesn't exist");
        }

    }
}