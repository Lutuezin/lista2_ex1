using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lista2_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] e = Console.ReadLine().Split(' ');
            int a, b, c, d;
            
            a = int.Parse(e[0]);
            b = int.Parse(e[1]);
            c = int.Parse(e[2]);
            d = int.Parse(e[3]);


            int soma = c + d;
         
           int  soma1 = a + b;
            if (b > c && d > a && soma > soma1 && c > 0 && d > 0 && a%2 ==0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }



            Console.ReadKey();


        }
    }
}
