using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funzioni_array_ripasso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dichiarazioni
            int n = 0;
            int[] array1 = new int[100];
            Console.WriteLine("inserisci la dimensione dell'array");
            n=int.Parse(Console.ReadLine());
            ArrayC(n, array1);
            OutputH(array1, n);
        }
        static void ArrayC(int n, int[] array1)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                array1[i] = r.Next(10);
            }
        }
        static void OutputH(int[] array1,int n)
        {
            
        }

    }     
    }
