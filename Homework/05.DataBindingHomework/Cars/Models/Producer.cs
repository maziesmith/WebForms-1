using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace Models
{
    public class Producer
    {
        private ICollection<Model> models;

        public Producer()
        {
            this.models = new HashSet<Model>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Model> Models
        {
            get { return this.models; }
            set { this.models = value; }
        }
    }
}