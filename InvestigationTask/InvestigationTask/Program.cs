using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationTask
{
    class Program
    {
        public static string[] calculations;
        static Random rnd = new Random();
        
        static void Main(string[] args)
        {
            calculations = new string[5];

            for(int i = 0; i < 5; i++)
            {
                int no1, no2, ans;

                no1 = Random;

                no2 = Random;

                if (no1 > 100)
                {
                    ans = no1 - no2;

                    calculations[i] = no1.ToString() + "-" + no2.ToString() + "=" + ans.ToString();
                }
                else if (no1 > 300)
                {
                    ans = no1 + no2;

                    calculations[i] = no1.ToString() + "+" + no2.ToString() + "=" + ans.ToString();
                }                    
                else
                {
                    ans = no1 * no2;

                    calculations[i] = no1.ToString() + "*" + no2.ToString() + "=" + ans.ToString();
                }
                   
                Console.WriteLine(ans);
            }


            for (int i = 0; i < 5; i++)
            {
                string ans;

                do
                {
                    Console.WriteLine("\nPlease enter the equation for answer: " + (i + 1));

                    ans = Console.ReadLine();

                } while (ans != calculations[i]);
            }

            Console.WriteLine("\nWell done, you have completed this exercise");
            Console.ReadLine();
        }

        public static int Random
        {
            get { return rnd.Next(1, 250); }
        }
    }
}
