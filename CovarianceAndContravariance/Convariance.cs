using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    /// <summary>
    /// 
    /// </summary>
    class Convariance
    {
        public static void Test()
        {
            /*
            https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/variance-in-generic-interfaces
            1. Starting with .NET Framework 4, the following interfaces are variant:
            IEnumerable<T> (T is covariant)
            IEnumerator<T> (T is covariant)
            IQueryable<T> (T is covariant)
            IGrouping<TKey,TElement> (TKey and TElement are covariant)

            IComparer<T> (T is contravariant)
            IEqualityComparer<T> (T is contravariant)
            IComparable<T> (T is contravariant)

            2. Starting with .NET Framework 4.5, the following interfaces are variant:
            IReadOnlyList<T> (T is covariant)
            IReadOnlyCollection<T> (T is covariant)
             */

            IEnumerable<DerivedClass> list1 = new List<DerivedClass>();

            // 父类接口 = 子类接口
            IEnumerable<BaseClass> list2 = list1;
        }
    }
}
