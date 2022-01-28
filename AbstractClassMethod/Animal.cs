using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassMethod
{
    abstract class Animal
    {
        public abstract void Sounds(); //Cant create the objects i nqma pole
        public void Sleep()
        {
            Console.WriteLine($"ZzZz");
        }
    }
        class Pig : Animal // Trqbva da se nasledi ot drug klas za da se izpolzva 
        {
            public override void Sounds()
            {
                Console.WriteLine($"Pig say wee wee");
            }
        }
    
}
