using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Cobro
    {
        public static double CobrarCuota(ICuota cuota)
        {
            double cuotaCobrada = 0;
            try
            {
                if (cuota is null)
                    throw new ArgumentNullException();
                else
                    cuotaCobrada = cuota.CalcularCuota();
            }
            catch(ArgumentNullException)
            {
            }
                return cuotaCobrada;
        }
        public static double CobrarArancel(IArancel arancel)
        {
            double arancelCobrado = 0;
            try
            {
                if (arancel is null)
                    throw new ArgumentNullException();
                else
                    arancelCobrado = arancel.CalcularArancel();
            }
            catch(ArgumentNullException)
            { }
            return arancelCobrado;
        }
    }
}
