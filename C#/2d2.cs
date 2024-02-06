using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication25
{
class darr2
{
    public static void Main(string[]args)
    {
        int[,] no=new int[3,3];
        no[0,0]=10;
        no[0,1]=20;
        no[0,2]=30;
        no[1,0]=40;
        no[1,1]=50;
        no[1,2]=60;
        no[2,0]=70;
        no[2,1]=80;
        no[2,2]=90;
        for(int i=0;i<=2;i++)
        {
            for(int j=0;j<=2;j++)
            {
                Console.WriteLine(no[i,j]);
            }
        }
        Console.ReadLine();
    }
}   
}