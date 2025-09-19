using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class convertinfix
    {
        private static string[] stack = new string[100];
        private static int top = -1;
        private static string st;            // infix : ((((a + b) * c) / d) - f)
        private static string tmp;           // infix : (((a + (b * c)) - (d / f)) - h)
        private static int A = 0;            // infix : ((a + (b * (c - d))) - (((e * f) + g) / h))


        public static void convert()
        {
            Console.Write(" Enter a Infix for Convert to postfix : ");
            st = Console.ReadLine();
            st = st.Trim();
            

            Console.Write(" postfix : ");
           
            for (int i = 0; i < st.Length; i++)
            {


                if (st[i] == '(' || st[i] == '+' || st[i] == '-' || st[i] == '*' || st[i] == '/')
                {
                    A = top;
                    if (i == 0)
                        stack[++top] = st[i] + "";
                    else
                        stack[++top] = stack[A] + st[i];

                }

                else if (st[i] >= 'A' && st[i] <= 'Z' || st[i] >= 'a' && st[i] <= 'z')
                {
                    Console.Write(" " + st[i]);
                }

                else if (st[i] == ')')
                {
                    tmp = stack[top];

                    for (int j = tmp.Length - 1; j >= 0; j--)
                    {
                        if (tmp[j] == '+' || tmp[j] == '-' || tmp[j] == '*' || tmp[j] == '/')
                        {
                            Console.Write(" " + tmp[j]);
                            tmp = tmp.Remove(j);

                        }

                        else if(tmp[j] == '(')
                        {
                            stack[++top] = tmp.Remove(j);
                            break;
                                   
                        }


                    }
                }
                           
            }

             
            
            Console.Write("\n exit to main menu (1) , convert another (2) ");
                if (Console.ReadKey().KeyChar == '1')
                    return;
                else
                    Console.Clear();
                convertinfix.convert();

            


        }
    }
}
