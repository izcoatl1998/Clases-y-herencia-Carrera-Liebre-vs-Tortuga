using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortugavsLiebre
{
    class tortuga : carrera

    {
        public tortuga(int a) : base(a)
        {
            this._posicion = 0;
        }

        new public int correr()
        {
            int avance = base.avanzar();
            return avance;
        }



    }
}
