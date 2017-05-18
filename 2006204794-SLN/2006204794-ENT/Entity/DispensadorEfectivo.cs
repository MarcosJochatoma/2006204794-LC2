using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794_ENT.Entity
{
    public class DispensadorEfectivo
    {

        public int idDispensadorefectivo { set; get; }
        public int contador { set; get; }

        public int idATM { set; get; }
        public ATM ATM { set; get; }

        public int idRetiro { set; get; }
        public Retiro Retiro { set; get; }
    }
}
