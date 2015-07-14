using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerDeEntidades
{
    public class ValidadorDeFechas
    {
        public bool FechaDeVigenciaEsValida(DateTime fechaDeVigencia,
            DateTime fechaDeRegistro)
        {
            bool laFechaEsValida = false;

            if (fechaDeVigencia >= fechaDeRegistro)
            {
                laFechaEsValida = true;
            }
            return laFechaEsValida;
        }
    }
}
