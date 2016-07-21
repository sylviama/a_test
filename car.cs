using System;

namespace vehicle{

    //Or could use: public class Car: Vehicle, ITransport
    public class Car: Vehicle
    
    
    {
        override public string Horn()
        {
            return "Didi";
        }

        override public string Color()
        {
            return "Blue";
        }
    }
}