using System;

namespace Moda
{
    class Moda
    {
        public static void Main(String [] arg)
        {
            Boolean resp = true;
            do
            {
                Console.WriteLine("Ingrese cuantos valores desea cargar: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num <= 0)
                {
                    Console.Write("Ingrese un valor entero positivo.\n");
                }
                else
                {            
                    suma(num);
                    resp = false;
                }

            } while (resp);
        }

        public static void suma(params int[] a) {
            int[] info = new int[a];
            Boolean resp;

            for (int cont = 0; cont < a; cont++)
            {
                resp = true;
                do
                {
                    Console.WriteLine("Ingrese el valor número " + (cont + 1) + ": ");
                    int respuesta = int.Parse(Console.ReadLine());


                    if(respuesta <= 0)
                    {
                        Console.WriteLine("Ingrese un valor entero positivo.\n");
                    }
                    else
                    {
                        info[cont] = respuesta;
                        resp = false;
                    }

                } while (resp);

            }
            int i, k, moda = info[0], mayor = 0, menor = 0;
            for ( i = 0; i < info.Length; i++)
            {
                for ( k = 1; k < info.Length; k++ ){
                    if (info[k] > info[i])
                    {
                    mayor = info[k];
                    }else if (info[k] < info[i]){
                        menor = info[k];
                    }
                }
            }
            i = 0;
            while (i < info.Length)
            {
                int numVeces = 0;
                k = 0;
                while (k < info.Length)
                {
                    if (info[k] == info[i]) numVeces++;
                    k++;
                }
                if (numVeces > moda)
                {
                    moda = info[i];
                }
                i++;


            }
            Console.WriteLine("El número que más veces aparece es el: " + moda);
            Console.WriteLine("El número maximo es: " + mayor);
            Console.WriteLine("El número minimo es: " + menor);
        }
    }
}