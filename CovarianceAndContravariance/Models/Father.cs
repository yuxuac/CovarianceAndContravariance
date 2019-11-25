using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance.Models
{
    class Father
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }

    class Child : Father
    {
        public int Age { get; set; }

        public override string ToString()
        {
            return this.Name + "-" + this.Age;
        }
    }
}
