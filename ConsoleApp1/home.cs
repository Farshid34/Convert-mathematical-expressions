using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class home
    {
        public static void homepage()
        {
            while (true)
            {
                showhelp();
                char s = Console.ReadKey().KeyChar;
                switch (s)
                {
                    case '4':
                        Environment.Exit(0);
                        break;
                   
                    case '1':
                        Console.Clear();
                        convertpostfix.convert();
                        break;
                   
                    case '2':
                        Console.Clear();
                        convertprefix.convert();
                        break;
                  
                    case '3':
                        Console.Clear();
                        convertinfix.convert();
                        break;
                  

                        
                       
                  
                }

            }
        }

        public static void showhelp()
        {
            Console.Clear();
            Console.WriteLine(" Home Page ");
            Console.WriteLine("1. Convert Postfix to Infix");
            Console.WriteLine("2. Convert Prefix to Infix ");
            Console.WriteLine("3. Convert Infix to Postfix ");
            Console.WriteLine("4. Exit");
        }



    }
}
