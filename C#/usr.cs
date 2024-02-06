using System;
class usrnm
{
    public static void Main()
    {
        string usr1="iyadfarooq";
        string usr2="atharbhat";
        string usr3="iamnasib";
        string usr4="vicky";
        string usr5="mohsinwani";
        string pswrd1="iyad123";
        string pswrd2="athar123";
        string pswrd3="nasib123";
        string pswrd4="vicky123";
        string pswrd5="mohsin123";

        Console.WriteLine("Enter your username");
        string usr=Console.ReadLine();
        if (usr==usr1)
        {
            
            Console.WriteLine("Enter your password");
            string pswrd=Console.ReadLine();
            if (pswrd==pswrd1)
            {
                Console.WriteLine("WELCOME "+usr);
            }
             else
            {
             Console.WriteLine("INVALID PASSWORD");
            }
           
        }
        
        else if (usr==usr2)
        {
            
            Console.WriteLine("Enter your password");
            string pswrd=Console.ReadLine();
            if (pswrd==pswrd2)
            {
                Console.WriteLine("WELCOME "+usr);
            }
             else
            {
             Console.WriteLine("INVALID PASSWORD");
            }
           
        }
        
        else if (usr==usr3)
        {
            
            Console.WriteLine("Enter your password");
            string pswrd=Console.ReadLine();
            if (pswrd==pswrd3)
            {
                Console.WriteLine("WELCOME "+usr);
            }
             else
            {
             Console.WriteLine("INVALID PASSWORD");
            }
           
        }
       
        else if (usr==usr4)
        {
            
            Console.WriteLine("Enter your password");
            string pswrd=Console.ReadLine();
            if (pswrd==pswrd4)
            {
                Console.WriteLine("WELCOME "+usr);
            }
             else
            {
             Console.WriteLine("INVALID PASSWORD");
            }
            
        }
       
        else if (usr==usr5)
        {
            
            Console.WriteLine("Enter your password");
            string pswrd=Console.ReadLine();
            if (pswrd==pswrd5)
            {
                Console.WriteLine("WELCOME "+usr);
            }
            else
            {
             Console.WriteLine("INVALID PASSWORD");
            }
            
        }
        else
        {
             Console.WriteLine("INVALID USERNAME");
        }

    }
}