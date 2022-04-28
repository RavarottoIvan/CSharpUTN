using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Apuesta
    {
        public Jugador participante { get; set; }
        public Dados dado = new Dados();
        public Apuesta(Jugador parti)
        {
            this.participante = parti;
        }

        public double Conservador(Jugador juga1, Jugador juga2, Maquina maqui1)
        {
            int maqui = maqui1.GetDado1() + maqui1.GetDado2();
            int jugar1 = juga1.GetDado1() + juga1.GetDado2();
            int jugar2 = juga2.GetDado1() + juga2.GetDado2();





            return 0;
        }

    }
}
