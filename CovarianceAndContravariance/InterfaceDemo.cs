using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    interface IGetAnimal<out A>
    {
        A GetAnimal();
    }

    interface ISetCat<in C>
    {
        void SetCat(C c);
    }

    class GetAnimalClass : IGetAnimal<Animal>
    {
        public Animal GetAnimal()
        {
            return new Animal();
        }
    }

    class GetCatClass : IGetAnimal<Cat>
    {
        public Cat GetAnimal()
        {
            return new Cat();
        }
    }

    class SetCatClass : ISetCat<Cat>
    {
        public Cat Cat { get; set; }
        public void SetCat(Cat c)
        {
            this.Cat = c;
        }
    }

    class SetAnimalClass : ISetCat<Animal>
    {
        public Animal Animal { get; set; }

        public void SetCat(Animal c)
        {
            this.Animal = c;
        }
    }

    class InterfaceDemo
    {
        // Matching interface signature
        IGetAnimal<Animal> getAnimal = new GetAnimalClass();
        // Convariance
        IGetAnimal<Animal> getCat = new GetCatClass();

        // Matching interface signature
        ISetCat<Cat> setCat = new SetCatClass();
        // Contravariance
        ISetCat<Cat> setAnimal = new SetAnimalClass();
    }
}
