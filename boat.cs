using System;

namespace vehicle
{


    public class Boat: Vehicle
    {
        override public string Horn()
        {
            return "Woooooo";
        }

        override public int Wheels()
        {
            return 0;
        }

        override public string Color()
        {
            return "Yellow";
        }
    }

}