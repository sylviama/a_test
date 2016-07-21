using System;

namespace vehicle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car my_car = new Car();
            Vehicle my_vehicle=new Vehicle();
            Boat my_boat =new Boat();
            Truck my_truck=new Truck();

            //this is the part using interface
            ITransport my_new_cargo=new Car();
            my_new_cargo.AddCargo();

            ITransport my_speed=new Vehicle();
            Console.WriteLine(my_speed.GetCurrentSpeed());

            //get;set; thing
            my_vehicle.NumberOfWheels=4;
            Console.WriteLine("Number of Wheels: "+ my_vehicle.NumberOfWheels);

            Console.WriteLine("wheel Car: "+ my_car.Wheels());
            Console.WriteLine("wheel Car: "+ my_boat.Wheels());
            Console.WriteLine("Boat Horn: " + my_boat.Horn());
            Console.WriteLine("Truck Horn: "+ my_truck.Horn());
            Console.WriteLine("Truck Color: "+ my_truck.Color());


        }
    }
}
