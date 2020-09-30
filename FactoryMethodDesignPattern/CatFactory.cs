using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    public class CatFactory : AnimalFactory
    {
        public override IAnimal GetAnimal()
        {
            return new Cat();
        }
    }
}
