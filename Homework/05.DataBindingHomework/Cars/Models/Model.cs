using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Model
    {
        private ICollection<Car> cars;

        public Model()
        {
            this.cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int ProducerId { get; set; }

        public virtual Producer Producer { get; set; }

        public int EngineId { get; set; }

        public virtual Engine Engine { get; set; }

        public ICollection<Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }
    }
}