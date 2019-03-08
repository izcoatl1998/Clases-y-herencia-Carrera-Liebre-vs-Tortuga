using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortugavsLiebre
{
    class carrera
    {

        private int _numCorredor;
        protected int _posicion;
        public int numCorredor { get { return _numCorredor; } }
        public int posicion { get { return _posicion; } }

        private static Random random = new Random();

        public carrera(int a)
        {
            _posicion = 0;
            _numCorredor = a;
        }

        //public int posicion
        //{
        //  get { return _posicion; }
        //}


        public int avanzar()
        {

            if (numCorredor == 1)           //codigo para la liebre
            {
                int a = random.Next(3, 6);
                int b = random.Next(1, 4);

                if (a == 4)
                {
                    if (b == 1)
                        _posicion += 0;
                    else if (b == 2)
                        _posicion += 5;
                    else
                        _posicion -= 8;
                }
                else if (a == 3)
                    _posicion -= 4;
                else
                    _posicion += 12;
            }
            else
            {
                //codigo para la tortuca
                {
                    int a = random.Next(1, 3);
                    int b = random.Next(1, 4);

                    if (a == 1)
                        _posicion += 3;
                    else
                    {
                        if (b == 1)
                            _posicion += 6;
                        else if (b == 2)
                            _posicion -= 5;
                        else
                            _posicion -= 9;
                    }

                }

            }

            return _posicion;

        }


    }
}
