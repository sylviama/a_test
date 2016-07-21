using System;

namespace vehicle
{
     interface ITransport
     {
        string GetCurrentSpeed();
        void AddCargo();
    }
}