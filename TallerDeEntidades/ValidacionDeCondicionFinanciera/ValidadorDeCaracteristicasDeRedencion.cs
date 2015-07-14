using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerDeEntidades
{
    class ValidadorDeCaracteristicasDeRedencion
    {
        public bool CaracteristicasDeRedencionSonValidas(bool permiteRedencion, double comision, int periodoMinimoDeRetencionEnDias)
        {
            bool sonValidas = false;

            if (permiteRedencion = false && comision == 0 && periodoMinimoDeRetencionEnDias == 0)
            {
                sonValidas = true;
            }
            else if (permiteRedencion = true && comision > 0 && periodoMinimoDeRetencionEnDias > 0)
            {
                sonValidas = true;
            }
            return sonValidas;
        }
    }
}
