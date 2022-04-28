using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Dados
    {
        public int Lanzar()
        {
            Random random = new Random();
            int a = random.Next(1,7);
            return a;
        }
    }
}
