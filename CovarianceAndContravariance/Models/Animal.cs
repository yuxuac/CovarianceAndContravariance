using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    public class Animal
    {
        public string Name { get; set; }
        public decimal Size { get; set; }

        public override string ToString()
        {
            return "Animal:" + this.Name + "(size:" + this.Size + ") is eating...";
        }
    }

    public class Cat : Animal
    {
        public override string ToString()
        {
            return "Cat:" + this.Name + "(size:" + this.Size + ") is eating...";
        }
    }
}
