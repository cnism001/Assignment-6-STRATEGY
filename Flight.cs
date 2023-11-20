using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_STRATEGY
{
    public interface IFlight
    {
        string Fly();
    }

    public class FlyWithWings : IFlight
    {
        public string Fly() => "FLIES BY FLAPPING ITS WINGS";
    }

    public class NoFly : IFlight
    {
        public string Fly() => "HIDES IT'S HEAD IN THE SAND AS IT CANNOT FLY";
    }

    public class Slide : IFlight
    {
        public string Fly() => "SLIDES ON IT'S BELLY";
    }

    public class Float : IFlight
    {
        public string Fly() => "FLOATS IN WATER";
    }

}
