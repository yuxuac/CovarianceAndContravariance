using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    delegate A GetAnimalDelegate<out A>();
    delegate void SetCatDelegate<in C>(C input);

    class DelegatesDemo2
    {
        public static void Demo()
        {
            // Match delegate signature
            GetAnimalDelegate<Animal> getADelegate2 = new GetAnimalDelegate<Animal>(GetAnimal);
            // Covariance
            GetAnimalDelegate<Animal> getADelegate1 = new GetAnimalDelegate<Cat>(GetCat);

            // Match delegate signature
            SetCatDelegate<Cat> setCatDelegate2 = new SetCatDelegate<Cat>(SetCat);
            // Contravariance
            SetCatDelegate<Cat> setCatDelegate1 = new SetCatDelegate<Animal>(SetAnimal);
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
