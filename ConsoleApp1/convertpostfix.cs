using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class convertpostfix
    {
        
        private static string[] stack= new string[100];
        private static int top = -1;
        private static string st;              // postfix : a b + c * d e / -  
        private static int A = 0;              // postfix : a b c * + d f / - h -
                                               // postfix : A B + C * D E - F G + * -
                                               // postfix : a b c d - * + e f * g + h / -


        public static void convert()
        {
            Console.Write(" Enter a Postfix for Convert to Infix : ");
            st = Console.ReadLine();
            st = st.Trim();


            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] >= 'A' && st[i] <= 'Z' || st[i] >= 'a' && st[i] <= 'z')
                {
                   
                  stack[++top] = " " + st[i] + " ";
                   
                }
                
                else if (st[i] == '+' || st[i] == '-' || st[i] == '*' || st[i] == '/')
                {
                    A = top;
                    stack[--top] = "(" + stack[--A] + st[i] + stack[++A] + ")";
                    stack[A] = null;
                }
                       
            }

            Console.WriteLine(" infix : " + stack[top]);

            Console.Write(" exit to main menu (1) , convert another (2) ");
            if (Console.ReadKey().KeyChar == '1')
                return;
            else
                Console.Clear();
                convertpostfix.convert();

        }




    }
}
