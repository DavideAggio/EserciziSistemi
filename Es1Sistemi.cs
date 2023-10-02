using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDec_Bin_Bin_Dec
{
    internal class Es1Sistemi
    {
        static void Main(string[] args)
        {
            bool[] b = { false, false, false, true, true, true, false, true, true, true, false, true};
            int[] dp = { 10, 10,10,10};
            int intero, decimale;
            decimale = Convert_Decimale_Puntato_To_Decimale(dp);
            //intero = Convert_Binario_To_Intero(b);
            Console.ReadLine();
        }
        static int Convert_Binario_To_Intero(bool[] b)
        {
            int intero=0;
            int k = b.Length-1;
            for(int i= 0; i <b.Length; i++)
            {
                if (b[i])
                    intero += (int)(Math.Pow(2, k));
                k--;
            }
            return intero;
        }
        static int Convert_Decimale_Puntato_To_Decimale(int[]dp)
        {
            int decimale = 0;
            int k = dp.Length - 1;
            for (int i = 0; i < dp.Length; i++)
            {
                decimale += (int)(Math.Pow(256, k));
                k--;
            }
            Console.WriteLine(decimale);
            return decimale;
        }


    }
}
