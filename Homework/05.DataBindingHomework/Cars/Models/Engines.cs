using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Engine
    {
        private ICollection<Model> models;

        public Engine()
        {
            this.models = new HashSet<Model>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Model> Models
        {
            get { return this.models; }
            set { this.models = value; }
        }
    }
}