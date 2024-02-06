using System;
class dup
{
    public static void Main()
    {
        int[] value=new int[4];
        value[0]=20;
        value[1]=30;
        value[2]=20;
        value[3]=40;
        for(int i=0;i<=3;i++)
        {
            for(int j=1;j<=3;j++)
            {
                if(i!=j)
                {
                    if(value[i]==value[j])
                    {
                        Console.WriteLine("duplicate");
                    }
                }
            }
        }
    }
}