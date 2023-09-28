using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Factories_Design_Pattern {
    //Both the Lion and Tiger classes will
    //Implement the IAnimal interface method
    public interface IAnimal {
        void AboutMe();
    }

    //Lion class
    public class Lion : IAnimal {
        public void AboutMe() => WriteLine("This is Lion.");
    }

    public class Tiger : IAnimal {
        public void AboutMe() => WriteLine($"This is Tiger");
    }

    public abstract class AnimalFactory { 
        /*
            Factory method lets a class defer instantiation to subclasses,
            The following method will create a Tiger or a Lion
            but at this point it does not know whether it will get a Lion or a Tiger.
            So, the following method is acting like a factory (of creation).
         */
        public abstract IAnimal CreateAnimal();
    }
    //Lion factory is used to create Lions
    public class LionFactory : AnimalFactory {
        //Creating a Lion
        public override IAnimal CreateAnimal() => new Lion();
    }

    public class TigerFactory : AnimalFactory {
        //Creating a Tiger
        public override IAnimal CreateAnimal() {
            return new Tiger();
        }
    }
}
