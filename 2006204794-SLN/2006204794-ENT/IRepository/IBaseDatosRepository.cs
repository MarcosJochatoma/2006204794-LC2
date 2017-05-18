using _2006204794_ENT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794_ENT.IRepository
{
    public interface IBaseDatosRepository : Repository<BaseDatos>
    {
        IEnumerable<BaseDatos> getBaseDatosxATM(ATM ATM);
        IEnumerable<BaseDatos> getBaseDatosxRetiro(Retiro Retiro);
        IEnumerable<BaseDatos> getBaseDatosxCuenta(Cuenta Cuenta);
    }
}
