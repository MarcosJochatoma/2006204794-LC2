using _2006204794_ENT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794_ENT.IRepository
{
    public interface IRanuraDepositoRepository : Repository<RanuraDeposito>
    {
        IEnumerable<RanuraDeposito> getRanuraporATM(ATM ATM);
    }
}
