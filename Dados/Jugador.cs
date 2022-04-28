using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Jugador
    {
        public int dinero = 100;
        public int dado1, dado2;
        public int GetDinero()
        {
            return dinero;
        }
        public void SetDinero(int noDinero)
        {
            this.dinero = noDinero;
        }

        public int GetDado1()
        {
            return dado1;
        }
        public void SetDado1(int Dado1)
        {
            this.dado1 = Dado1;
        }
        public int GetDado2()
        {
            return dado1;
        }
        public void SetDado2(int Dado2)
        {
            this.dado2 = Dado2;
        }

    }
}
