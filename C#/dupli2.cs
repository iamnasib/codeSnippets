using System;
class dup
{
    public static void Main()
    {
        int[] value=new int[4];
        Console.WriteLine("enter the value at first place");
        value[0]=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the value at second place");
        value[1]=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the value at third place");
        value[2]=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the value at fourth place");
        value[3]=Convert.ToInt32(Console.ReadLine());
        if(value[0]==value[1])
        {
            Console.WriteLine("Duplicate value at first & second place");
        }
        else if(value[0]==value[2]) 
        {
            Console.WriteLine("Duplicate value at first & third place");
        }
        else if(value[0]==value[3]) 
        {
            Console.WriteLine("Duplicate value at first & fourth place");
        }
        else if(value[1]==value[2]) 
        {
            Console.WriteLine("Duplicate value at second & third place");
        }
        else if(value[1]==value[3]) 
        {
            Console.WriteLine("Duplicate value at second & fourth");
        }
        else if(value[2]==value[3]) 
        {
            Console.WriteLine("Duplicate value at third & fourth place");
        }
        else 
        {
            Console.WriteLine("No duplicate value");
        }
    }
}