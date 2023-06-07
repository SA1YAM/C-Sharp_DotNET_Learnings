using System;


namespace OOPS
{
    public class Animal
    {
        private int legs = 4;
        public virtual int Legs { 
            get { return legs; }
            set {
                if (value == 1 || value == 3 || value > 4) {
                    throw new ArgumentOutOfRangeException(nameof(value), "The valid value is 2 or 4");
                }
            }
        }

        public virtual void Sound()
        {
            Console.WriteLine("This is the sound of an animal");
        }
    }

    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("A Dog will Bark");
            base.Sound();
        }
    }
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("A Cat will meow");
            base.Sound();
        }
    }
    public class Lion : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("A Lion will Roar");
            base.Sound();
        }
    }
}
