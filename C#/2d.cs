using System;
class darr
{
    public static void Main()
    {
        int[,] num=new int[3,3];
        num[0,0]=10;
        num[0,1]=20;
        num[0,2]=30;
        num[1,0]=40;
        num[1,1]=50;
        num[1,2]=60;
        num[2,0]=70;
        num[2,1]=80;
        num[2,2]=90;
        foreach(int x in num)
        {
            Console.WriteLine(x);
        }



    }
}