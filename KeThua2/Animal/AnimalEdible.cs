using System;

namespace Animal
{
    public abstract class Animal
    {
        public abstract string makeSound();
        
    }
    public interface   Edible
    {
        public  string howtoEat();
    }
    public class Tiger : Animal
    {
        public override string makeSound()
        {
            return "Tiger: Roarrrrrr";
        }
    }
    public class Chicken: Animal , Edible
    {
        public override string makeSound()
        {
            return "Chicken: cluck-cluck";
        }
        public  string howtoEat()
        {
            return "could be fried";
        }
    }
    public abstract class Fruit : Edible
    {
        public abstract string howtoEat();
    }
    public class Apple : Fruit
    {
        public override string howtoEat()
        {
            return "Apple could be slided";
        }
    }
    public class Orange : Fruit
    {
        public override string howtoEat()
        {
            return "Orange could be juiced";
        }
    }
}
