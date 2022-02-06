using System;

namespace Home_Work_Method_3_
{
    class Program
    {
        static void Main(string[] args)
        {

            int size;

            Console.WriteLine("Tedris Aldiginiz Fenn Sayi");

            int.TryParse(Console.ReadLine(), out size);

            Console.WriteLine("Qiymetleri daxil edin");

            ArrayCreater(size);
            int[] arr = new int[size];
            CalcAvg(arr);
            
        }
        static void CalcAvg(int[] arr2)
            {
            int result = 0;

            int temp = 0;

            int netice;

            for (int i = 0; i < arr2.Length; i++)
            {
                result = result + arr2[i];
                temp++;
            }

            netice = result / temp;

            if (netice < 60)
            {
                Console.WriteLine("Mezun ola bilmediniz");
            }
            else
            {
                Console.WriteLine("Mezun oldunuz");
            }



        }

        static int[] ArrayCreater(int arrayinuzunlugu)
        {


            int[] arr = new int[arrayinuzunlugu];
            for (int i = 0; i < arr.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out arr[i]);

            }
            return arr;

        }


    }

    
}

