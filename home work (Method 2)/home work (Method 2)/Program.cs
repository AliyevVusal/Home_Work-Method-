using System;

namespace home_work__Method_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int.TryParse(Console.ReadLine(), out a);
            IsPrimeMath(a); 
        
        }
        static void IsPrimeMath(int a)
        {
            if (a == 2)
            {
                Console.WriteLine("Eded Sadedir");
            }
            
            for (int i = 2; i < a; i++)
            {
                
                if(a % i == 0)
                {
                    Console.WriteLine("Eded Murkebdir");
                    break;
                }
                else
                {
                    Console.WriteLine("Eded Sadedir");
                    break;
                }
                

            }

        }




    }

}
