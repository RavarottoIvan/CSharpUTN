using System;

namespace Dados
{
    internal class Program
    {
        public static void Main(String[] arg)
        {
            Dados lan = new Dados();
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();
            Maquina maquina1 = new Maquina();
            Apuesta apust = new Apuesta(jugador1);
            Apuesta apust2 = new Apuesta(jugador2);

            maquina1.SetDado1(lan.Lanzar());
            maquina1.SetDado2(lan.Lanzar());
            jugador1.SetDado1(lan.Lanzar());
            jugador1.SetDado2(lan.Lanzar());
            jugador2.SetDado1(lan.Lanzar());
            jugador2.SetDado2(lan.Lanzar());



            apust.Conservador(jugador1, jugador2, maquina1);



            /*
            Console.WriteLine("Ingrese un valor entre el 1 al 6: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            int a = lan.Lanzar();
            if (resp == a)
            {
                Console.WriteLine("Acertaste con tu respuesta: Número:"+ resp + " = Dado:" + a);
            }
            else
            {
                Console.WriteLine("NO acertaste con tu respuesta: Número:" + resp + " != Dado:" + a);
            }
            */
        }
    }
}