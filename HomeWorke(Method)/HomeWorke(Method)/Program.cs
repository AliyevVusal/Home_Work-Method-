using System;

namespace HomeWorke_Method_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sozu daxil edin");

            string a;

            a = Console.ReadLine();

            Console.WriteLine("Herif daxil edin");

            

            char b;

            char.TryParse(Console.ReadLine(), out b);

            FindCharIndex(a, b);



        }
    
        static void FindCharIndex(string soz,char herif)
        {
            //alma  a
            for (int i = 0; i < soz.Length; i++)
            {

                if (soz[i] == herif)
                {

                    Console.WriteLine(i);

                }
                else
                {
                    int g = -1;
                    Console.WriteLine(g);
                    break;
                }

            }
            

        }
    }

}
