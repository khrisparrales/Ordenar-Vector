using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordenar_Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] vector = { 4, 5, 6, 1, 2, 3, 4, 12, 6, 4, 2, 1, 5, 8, 9 };
            OrdenarDesc(vector);
            foreach (int valor in vector)
            {
                Console.Write(valor+" ");
            }
            Console.ReadKey();
        }
        public static int[] OrdenarDesc(int[] Ma, int n=0)
        {
            if (Ma.Length == n) { return Ma; }
            int aux = Ma[n];
            for (int i = n; i < Ma.Length; i++)
            {
                if (aux < Ma[i]) { aux = Ma[i]; Ma[i] = Ma[n]; Ma[n] = aux; }
            }
            return OrdenarDesc(Ma, n + 1);
        }
        public static int[] OrdenarAsc(int[] Ma, int n = 0)
        {
            if (Ma.Length == n) { return Ma; }
            int aux = Ma[n];
            for (int i = n; i < Ma.Length; i++)
            {
                if (aux > Ma[i]) { aux = Ma[i]; Ma[i] = Ma[n]; Ma[n] = aux; }
            }
            return OrdenarDesc(Ma, n + 1);
        }

    }
}
