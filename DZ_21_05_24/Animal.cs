using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_21_05_24
{
    public class Animal
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public virtual void Say() {
            Console.WriteLine($"{Name} что-то говорит!");
        }
        public Animal(string name) {
            this.Name = name;
        }
    }

    public class Dog : Animal {
        public Dog(string name) : base(name) { }

        public override void Say()
        {

            Console.WriteLine($"{Name} гавкает");
        }

    
    }

    public class Cat : Animal
    {

        public Cat(string name) : base(name) { }

        public override void Say()
        {

            Console.WriteLine($"{Name} мяукает");
        }

    }

    public class Parrot : Animal
    {

        public Parrot(string name) : base(name) { }

        public override void Say()
        {

            Console.WriteLine($"{Name} повторяет");
        }

    }
}
