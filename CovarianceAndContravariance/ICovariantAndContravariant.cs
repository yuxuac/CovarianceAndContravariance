using CovarianceAndContravariance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{


    interface ICovariantAndContravariant<out F, in C> where F : new()
                                                      where C : new()
    {
        F GetF();
        void SetC(C obj);
    }

    class TestConvariant<F, C> : ICovariantAndContravariant<F, C> where F : new()
                                                                  where C : new()
    {
        public F FObj { get; set; }
        public C CObj { get; set; }

        public F GetF()
        {
            if (FObj == null)
                FObj = new F();
            return FObj;
        }

        public void SetC(C obj)
        {
            CObj = obj;
        }
    }

    class Class1
    {
        public static void Demo()
        {
            ICovariantAndContravariant<Father, Child> ch = new TestConvariant<Child, Father>();
            ch.SetC(new Child() { Name = "Child", Age = 12 });
            var obj = ch.GetF();
        }
    }
}
