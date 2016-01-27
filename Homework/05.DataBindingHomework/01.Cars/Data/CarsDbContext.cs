using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext()
            : base("CarsSystem")
        {
        }

        public virtual IDbSet<Car> Cars { get; set; }
        public virtual IDbSet<Producer> Producers { get; set; }
        public virtual IDbSet<Model> Models { get; set; }
        public virtual IDbSet<Engine> Engines { get; set; }
        public virtual IDbSet<Extra> Extras { get; set; }

        public static DbContext Create()
        {
            return new CarsDbContext();
        }
    }
}
