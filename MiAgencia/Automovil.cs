using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgencia
{
    class Automovil : Vehiculo
    {
        #region Atributos
        int puertas;
        #endregion

        #region Constructor
        public Automovil()
        {
            this.puertas = 4;
        }

        public Automovil(int puertas)
        {
            this.puertas = puertas;
        }
        #endregion

        #region Metodos
        //
        #endregion
    }
}
