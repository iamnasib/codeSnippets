using System;
class reverseString
{
    public static void Main()
    {
        Console.WriteLine("enter text");
        string input=Console.ReadLine();
       
        for(int i=input.Length-1;i>=0;i--)
        {
            try
            {
            Console.Write(input[i]);
            }
            catch(Exception name)
            {
                Console.Write(name.Message);
            }
        }
        
    }
}