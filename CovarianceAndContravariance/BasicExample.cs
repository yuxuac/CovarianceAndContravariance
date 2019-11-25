using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    class BasicExample
    {
        static object GetObject() { return null; }
        static void SetObject(object obj) { }

        static string GetString() { return null; }
        static void SetString(string str) { }

        public static void Test()
        {
            string str = "hello";
            object obj = str;

            /*
             array types, delegate types, and generic type arguments
             */

            // Covariance: less derived type argument = more derived type argument
            IEnumerable<string> list1 = new List<string>();
            IEnumerable<object> list2 = list1;

            // Contravariance: more derived type argument = less derived type argument
            Action<object> action = new Action<object>((a) => { Console.WriteLine(a.ToString()); });
            Action<string> action2 = action;

            object[] array = new String[10];

            // Convariance:
            Func<object> func1 = GetString;

            // Contravariance:
            Action<string> action1 = SetObject;


            Console.WriteLine(array.Length);
            Console.ReadLine();
        }
    }
}
