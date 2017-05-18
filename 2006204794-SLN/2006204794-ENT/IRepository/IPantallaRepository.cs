using _2006204794_ENT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794_ENT.IRepository
{
    public interface IPantallaRepository : Repository<Pantalla>
    {
        IEnumerable<Pantalla> getPantallaxATM(ATM ATM);
        IEnumerable<Pantalla> getPantallaxRetiro(Retiro Retiro);
    }
}
