using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    /*
        IComparer<T> (T is contravariant)
        IEqualityComparer<T> (T is contravariant)
        IComparable<T> (T is contravariant)
    */

    class BaseComparer : IEqualityComparer<BaseClass>
    {
        public bool Equals(BaseClass x, BaseClass y)
        {
            return x == y;
        }

        public int GetHashCode(BaseClass obj)
        {
            return obj.GetHashCode();
        }
    }

    class Contravariance
    {
        public static void Test()
        {
            BaseComparer bc = new BaseComparer();

            // 子类接口 = 父类接口
            IEqualityComparer<DerivedClass> comparer = bc;
        }
    }
}
