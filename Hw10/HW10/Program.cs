using System;

namespace HW10Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport t = new Transport("Car" , 4 , "true"); 
            // t.Show();
            Auto mercedes = new Auto("AMG" , 4 , "false" , "Jet Black" , 2);
            mercedes.Show();
            mercedes.getInfo();
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
            System.Console.WriteLine("Base constructor - passed");
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
            System.Console.WriteLine("Executed child process");
        }

        public void getInfo()
        {
            System.Console.WriteLine($"Auto's color is {color}. It has {number_of_doors} doors.");
        }
    }
}
