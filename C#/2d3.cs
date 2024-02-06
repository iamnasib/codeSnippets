using System;
class darr3
{
    public static void Main()
    {
       string[,] my=new string[3,3];
       for(int i=0;i<=2;i++)
       {
           for(int j=0;j<=2;j++)
           {
               Console.WriteLine("Enter the name at"+ i+j);
               my[i,j]=Console.ReadLine();
           }
           
       }
       foreach(string x in my)
           {
               Console.WriteLine(x);
           }
    }
}