using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ModelId { get; set; }

        public virtual Model Model { get; set; }
    }
}
