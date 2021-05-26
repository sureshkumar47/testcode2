using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{

   public  class Logic
    {
        public void Display()
        {
            for(int i=0;i<100;i++)
            {
                if(i%3==0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    if(i%5==0)
                    {
                        Console.WriteLine("buzz");
                    }
                    else
                    {
                        if(i%3==0 && i%5==0)
                        {
                            Console.WriteLine("fizzbuzz");
                        }
                    }
                }
            }
        }
    }

    public class Reverse
    {
        public void Reverestring(string s)
        {
            StringBuilder st = new StringBuilder();
            int length = s.Length;
            for(int i=0;i<length; i++)
            {
                st.Append(s[s.Length]);
                length = length - 1;
            }
            Console.WriteLine("reverse string is " + st);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            logic.Display();
            Console.WriteLine("enter a string");
            string input = Console.ReadLine();
            Reverse reverse = new Reverse();
            reverse.Reverestring(input);
            Console.ReadLine();
        }
    }
}
