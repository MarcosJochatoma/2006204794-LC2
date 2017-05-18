using _2006204794_ENT.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794_PER.EntityConfiguration
{
    public class CuentaConfiguration : EntityTypeConfiguration<Cuenta>
    {
        public CuentaConfiguration()
        {

            ToTable("Cuenta");

            HasKey(a => a.idCuenta);
            HasRequired(c => c.BaseDatos).WithMany(g => g.listaCuentas).HasForeignKey(v => v.idBaseDatos);

        }

    }
}
