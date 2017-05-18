using _2006204794_ENT.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794_PER.EntityConfiguration
{
    public class RanuraDepositoConfiguration : EntityTypeConfiguration<RanuraDeposito>
    {

        public RanuraDepositoConfiguration()
        {

            ToTable("RanuraDeposito");

            HasKey(a => a.idRanuraDeposito);

        }

    }
}
