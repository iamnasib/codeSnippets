using System;
class binary
{
    public static void Main()
    {
        Console.WriteLine("Enter the number");
        int num=Convert.ToInt32(Console.ReadLine());
        binary obj=new binary();
        string n=obj.tobinary(num);
        Console.WriteLine(n);

    }
    public string tobinary(int num)
    {
       if(num==0)
    {
        return "0";
    } 
    string binary="";
    while(num>0)
    {
        int rem=num % 2;
        binary=rem+binary;
        num=num/2;
    }
    return binary;
    }
}