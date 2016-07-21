using System;

namespace vehicle
{

    public class Vehicle : ITransport
    {
        // double Speed;
        string ITransport.GetCurrentSpeed()
        {
            return "Speed!";
        }

        // string Cargo;
        void ITransport.AddCargo()
        {
            Console.WriteLine("Cargo!");
        }
       

        virtual public int Wheels()
        {
            return 4;
        } 

        public int NumberOfWheels{get;set;}


        virtual public string Horn()
        {
            return "Honk";
        }

        virtual public string Color()
        {
            return "red";
        }

    }

}