using System;

namespace Moda
{
    class Moda
    {
        public static void Main(String [] arg)
        {
            Console.WriteLine("Ingrese cuantos valores desea cargar: ");
            int num = int.Parse(Console.ReadLine());
            int[] info = new int[num];

            for (int cont = 0; cont < num; cont++)
            {
                Console.WriteLine("Ingrese el valor número " + (cont + 1) + ": ");
                int respuesta = int.Parse(Console.ReadLine());
                info[cont] = respuesta;
            }

            suma(info);

        }

        public static void suma(int[] a)
        {
            int i, k, moda = a[0], mayor = 0, menor = 0;
            for ( i = 0; i < a.Length; i++)
            {
                for ( k = 1; k < a.Length; k++ ){
                    if (a[k] > a[i])
                    {
                    mayor = a[k];
                    }else if (a[k] < a[i]){
                        menor = a[k];
                    }
                }
            }
            i = 0;
            while (i < a.Length)
            {
                int numVeces = 0;
                k = 0;
                while (k < a.Length)
                {
                    if (a[k] == a[i]) numVeces++;
                    k++;
                }
                if (numVeces > moda)
                {
                    moda = a[i];
                }
                i++;


            }
            Console.WriteLine("El número que más veces aparece es el: " + moda);
            Console.WriteLine("El número maximo es: " + mayor);
            Console.WriteLine("El número minimo es: " + menor);
        }
    }
}