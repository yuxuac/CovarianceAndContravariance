using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    // Covariance
    delegate Animal GetAnAnimal();

    // Contravariance
    delegate void CallCatAction(Cat cat);

    class DelegatesDemo
    {
        public static void Demo()
        {
            // 1. Convariance
            // Matching method signature
            GetAnAnimal method2 = GiveMeAnAnimal;

            // Return more derived type: Cat
            GetAnAnimal method1 = GiveMeACat;

            // 2. Contravariance
            // Matching method signature
            CallCatAction method3 = CatTakeAction;

            // Accept less derived type: Animal
            CallCatAction method4 = AnimalTakeAction;
        }

        public static Cat GiveMeACat()
        {
            return new Cat();
        }

        public static Animal GiveMeAnAnimal()
        {
            return new Animal();
        }

        public static void CatTakeAction(Cat cat)
        {
            Console.WriteLine(cat.ToString());
        }

        public static void AnimalTakeAction(Animal animal)
        {
            Console.WriteLine(animal.ToString());
        }
    }
}
