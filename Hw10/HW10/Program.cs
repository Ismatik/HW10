using System;

namespace HW10Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Transport t = new Transport("Car" , 4 , "true"); 
            // t.Show();
            // Auto mercedes = new Auto("AMG" , 4 , "false" , "Jet Black" , 2);
            // mercedes.Show();
            // mercedes.getInfo();
            // Airplane airplane = new Airplane("Airplane" , 2 , "true" , "Somon Air");
            // airplane.Show();
            // airplane.getInfo();
            Passenger_car p_car = new Passenger_car()
            {
                Auto = new Auto[]
                {
                    new Auto {transportName = "buggati" , number_of_wheels = 4, canFly = "false" , color = "Black&White", number_of_doors = 2}
                }, 
                transportName = "ferrari",
                number_of_wheels = 4,
                canFly = "false",
                color = "Red",
                number_of_doors = 2
            };
            p_car.getInfo();
            p_car.Show();
        }
    }

    class Transport
    {
        public string transportName {get;set;}
        public int number_of_wheels {get;set;}
        public string canFly {get;set;}

        public Transport()
        {
        }
        public Transport(string TransportName, int Number_of_wheels, string CanFly)
        {
            transportName = TransportName;
            number_of_wheels = Number_of_wheels;
            canFly = CanFly;
            System.Console.WriteLine("Transport - passed");
        }

        public void Show()
        {
            Console.WriteLine($"The transport is {transportName}. It has {number_of_wheels} wheels. It is {canFly} - transport can fly.");
        }
    }

    class Auto : Transport
    {
        public string color;
        public int number_of_doors;
        
        public Auto()
        {
        }
        public Auto(string transportName, int number_of_wheels, string canFly, string color, int number_of_doors) : base(transportName, number_of_wheels, canFly)
        {
            this.color = color;
            this.number_of_doors = number_of_doors;
            System.Console.WriteLine("Auto - passed");
        }

        public void getInfo()
        {
            System.Console.WriteLine($"Auto's color is {color}. It has {number_of_doors} doors.");
        }
    }

    class Airplane : Transport
    {
        public string air_company;
        public Airplane(string transportName, int number_of_wheels, string canFly, string air_company) : base(transportName, number_of_wheels, canFly)
        {
            this.air_company  = air_company;
            // System.Console.WriteLine("Airplane - passed");
        }

        public Airplane()
        {

        }

        public void getInfo()
        {
            System.Console.WriteLine($"Air company of this airplane is {air_company}");
        }
    }

    class Passenger_car : Auto
    {
        public Auto[] Auto;

        public void List_of_cars()
        {   
            if(Auto == null) return;
            foreach (var cars in Auto)
            {
                cars.getInfo();
            }
        }
    }

    class Cargo_car : Auto
    {
        public Auto[] Auto;

        public void List_of_cars()
        {   
            if(Auto == null) return;
            foreach (var cars in Auto)
            {
                cars.getInfo();
            }
        }
    }

    class Cargo_airplane : Airplane
    {
        public Airplane[] Airplane;
        public string weight;

        public void List_of_corgo_airplanes()
        {
            if(Airplane == null) return;
            foreach (var plane in Airplane)
            {
                plane.getInfo();
            }
        }
    }

    class Passenger_airplane : Airplane
    {
        public Airplane[] Airplane;
        public int number_of_passengers;
        public void List_of_corgo_airplanes()
        {
            if(Airplane == null) return;
            foreach (var plane in Airplane)
            {
                plane.getInfo();
            }
        }
        public Passenger_airplane()
        {

        }
        public Passenger_airplane(string transportName, int number_of_wheels, string canFly, string air_company, int number_of_passengers) : base(transportName, number_of_wheels, canFly,air_company)
        {
            this.number_of_passengers = number_of_passengers;
        } 
    }
}
