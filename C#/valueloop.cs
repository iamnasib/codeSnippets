using System;
class value
{
    public static void Main()
    {
        int flag=1;
        int[] value=new int[5];
        value[0]=100;
        value[1]=200;
        value[2]=300;
        value[3]=400;
        value[4]=500;
        Console.WriteLine("enter the value");
        int va=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<=4;i++)
       {
       if(va==value[i])
       {
          
           flag=3;
           break;
       }
       else
       {
            
            flag=4;
            
       }
       }
       if(flag==3)
       {
           Console.WriteLine("value exists");
       }
       else
       {
           Console.WriteLine("value not exist");
       }
       
    }
}