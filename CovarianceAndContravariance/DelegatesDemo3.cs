using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    /// <summary>
    /// Func and Action
    /// </summary>
    class DelegatesDemo3
    {
        public static void Demo()
        {
            // Match delegate signature
            Func<Animal> getADelegate2 = new Func<Animal>(GetAnimal);
            // Covariance
            Func<Animal> getADelegate1 = new Func<Cat>(GetCat);

            // Match delegate signature
            Action<Cat> setCatDelegate2 = new Action<Cat>(SetCat);
            // Contravariance
            Action<Cat> setCatDelegate1 = new Action<Animal>(SetAnimal);
        }

        public static Animal GetAnimal() { return new Animal(); }

        public static Cat GetCat() { return new Cat(); }

        public static void SetAnimal(Animal animal)
        {
            Console.WriteLine("Set Animal:" + animal.Name);
        }

        public static void SetCat(Cat cat)
        {
            Console.WriteLine("Set Cat:" + cat.Name);
        }
    }
}
