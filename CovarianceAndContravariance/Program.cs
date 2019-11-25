using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    // Convariant接口
    public interface IConvariance<out A>
    {
        A GetAnAnimal();
    }

    // Contravariant接口
    public interface IContravariance<in C>
    {
        void TakeAction(C c);
    }

    public class AnimalCollection<A> : IConvariance<A> where A : new()
    {
        public A GetAnAnimal()
        {
            return new A();
        }
    }

    public class AnimalsTakeAction<C> : IContravariance<C> where C : new()
    {
        public void TakeAction(C c)
        {
            Console.WriteLine(c.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Animal = Cat
            IConvariance<Animal> convariance = new AnimalCollection<Cat>();
            var animal = convariance.GetAnAnimal();

            // Cat = Animal
            IContravariance<Cat> contravariance = new AnimalsTakeAction<Animal>();
            Animal aa = new Animal() { Name = "a", Size = 10m };
            contravariance.TakeAction((Cat)aa);
        }
    }
}
