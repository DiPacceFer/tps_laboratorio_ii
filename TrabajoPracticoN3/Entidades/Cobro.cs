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
            if (cuota is null)
                throw new ArgumentNullException();
            return cuota.CalcularCuota();
        }
        public static double CobrarArancel(IArancel arancel)
        {
            if (arancel is null)
                throw new ArgumentNullException();
            return arancel.CalcularArancel();
        }
    }
}
