using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_STRATEGY
{
    public abstract class Bird
    {
        //can only be accesses from Bird class or its inheritors
        protected IFlight flight { get; set; }

        // Method to perform the fly action, which utilizes the IFlight's Fly method
        public string PerformFly() => flight.Fly();
    }

    // MallardDuck class inheriting from Bird, same for other bird subclasses
    public class MallardDuck : Bird
    {
        public MallardDuck()
        {
            this.flight = new FlyWithWings();
        }
    }

    public class EmperorPenguin : Bird
    {
        public EmperorPenguin()
        {
            this.flight = new Slide();
        }
    }

    public class BaldEagle : Bird
    {
        public BaldEagle()
        {
            this.flight = new FlyWithWings();
        }
    }

    public class Ostrich : Bird
    {
        public Ostrich()
        {
            this.flight = new NoFly();
        }
    }

    public class YellowRubberDuck : Bird
    {
        public YellowRubberDuck()
        {
            this.flight = new Float();
        }
    }

}
