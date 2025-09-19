using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class convertprefix
    {
        private static string[] stack = new string[100];
        private static int top = -1;
        private static string st;               // prefix: - * + a b c * - d e + f g
        private static int A = 0;               // prefix: - - + a * b c / d f h


        public static void convert()
        {
           
            Console.Write(" Enter a Prefix for Convert to Infix : ");
            st = Console.ReadLine();
            st = st.Trim();


            for (int i = st.Length - 1; i >= 0; i--)
            {
                if (st[i] >= 'A' && st[i] <= 'Z' || st[i] >= 'a' && st[i] <= 'z')
                {

                    stack[++top] = " " + st[i] + " ";

                }

                else if (st[i] == '+' || st[i] == '-' || st[i] == '*' || st[i] == '/')
                {
                    A = top;
                    stack[--top] = "(" + stack[A] + st[i] + stack[--A] + ")";
                    stack[++A] = null;
                }
                

            }

            Console.WriteLine(" infix : " + stack[top]);

            Console.Write(" exit to main menu (1) , convert another (2) ");
            if (Console.ReadKey().KeyChar == '1')
                return;
            else
                Console.Clear();
            convertprefix.convert();

        }



    }
}
