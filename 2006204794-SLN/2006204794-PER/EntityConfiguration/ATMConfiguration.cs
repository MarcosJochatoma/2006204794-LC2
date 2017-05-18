using _2006204794_ENT.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794_PER.EntityConfiguration
{
    public class ATMConfiguration : EntityTypeConfiguration<ATM>
    {

        public ATMConfiguration()
        {

            ToTable("ATM");

            HasKey(a => a.idATM);
            HasRequired(c => c.dispensadorEfectivo).WithRequiredPrincipal(c => c.ATM);
            HasRequired(c => c.pantalla).WithRequiredPrincipal(c => c.ATM);
            HasRequired(c => c.teclado).WithRequiredPrincipal(c => c.ATM);
            HasOptional(c => c.Retiro).WithRequired(c => c.ATM);
            HasRequired(c => c.ranuradeposito).WithRequiredPrincipal(c => c.ATM);


        }
    }
}
