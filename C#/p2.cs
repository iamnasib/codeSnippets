using System;
class usrnm
{
    public static void Main()
    {
        int flag=0;
        string[] usr=new string[5];
        usr[0]="iyadfarooq";
        usr[1]="atharbhat";
        usr[2]="iamnasib";
        usr[3]="vicky";
        usr[4]="mohsinwani";
        string[] pswrd=new string[5];
        pswrd[0]="iyad123";
        pswrd[1]="athar123";
        pswrd[2]="nasib123";
        pswrd[3]="vicky123";
        pswrd[4]="mohsin123";

        Console.WriteLine("Enter your username");
        string usrn=Console.ReadLine();
        Console.WriteLine("Enter your pswrd");
        string pass=Console.ReadLine();

        for(int i=0;i<=4;i++)
        {
           
                if(usrn==usr[i])
                {
                    
                    if(pass==pswrd[i])
                    {
                        flag=1;
                        
                    }
                    else
                    {
                        flag=2;
                        
                        
                    }
                     }
                
                else
                    {
                        Console.WriteLine("incorrect username");
                        
                    }
                    if(flag==1)
                    {
                      Console.WriteLine("welcome");
                    }
                    else if(flag==2)
                    {
                      Console.WriteLine("incorrect pswrd");
                    }

            
        }
    }
}        
       