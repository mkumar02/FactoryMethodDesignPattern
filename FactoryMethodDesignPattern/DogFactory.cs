namespace FactoryMethodDesignPattern
{
    public class DogFactory : AnimalFactory
    {
        public override IAnimal GetAnimal()
        {
            return new Dog();
        }
    }
}
