using _2006204794_ENT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794_ENT.IRepository
{

    public interface IATMRepository : Repository<ATM>
    {
        IEnumerable<ATM> getATMxRanura(RanuraDeposito RanuraDeposito);
        IEnumerable<ATM> getATMxTeclado(Teclado Teclado);
        IEnumerable<ATM> getATMxDispensadorEfectivo(DispensadorEfectivo DispensadorEfectivo);
        IEnumerable<ATM> getATMxPantalla(Pantalla Pantalla);
        IEnumerable<ATM> getATMxRetiro(Retiro Retiro);
        IEnumerable<ATM> getATMxBaseDatos(BaseDatos BaseDatos);
    }
}
