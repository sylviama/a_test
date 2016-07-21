using System;

namespace vehicle
{

    public class Truck: Vehicle
    {
        override public string Horn()
        {
            return "WaaTruck";
        }

        override public string Color()
        {
            return "White";
        }
    }
}