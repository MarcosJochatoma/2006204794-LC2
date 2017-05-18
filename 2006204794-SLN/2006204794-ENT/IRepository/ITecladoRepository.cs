using _2006204794_ENT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794_ENT.IRepository
{
    public interface ITecladoRepository : Repository<Teclado>
    {

        IEnumerable<Teclado> getTecladoporATM(ATM ATM);
        IEnumerable<Teclado> getTecladoporRetiro(Retiro Retiro);
    }
}
