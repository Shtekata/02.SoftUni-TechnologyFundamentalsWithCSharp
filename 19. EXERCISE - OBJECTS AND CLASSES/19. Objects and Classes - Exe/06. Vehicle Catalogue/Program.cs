using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var catalogue = new List<Vehicle>();
            while (input != "End")
            {
                var newInput = input.Split();
                var newVehicle = new Vehicle(newInput[0], newInput[1], newInput[2], newInput[3]);
                catalogue.Add(newVehicle);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "Close the Catalogue")
            {
                Console.WriteLine(catalogue.Find(x => x.Model == input));
                input = Console.ReadLine();
            }
            var onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            var onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();
            var carsHorsePower = 0.0;
            var truckHorsePower = 0.0;

            foreach (var item in onlyCars)
            {
                carsHorsePower += item.HorsePower;
            }
            foreach (var item in onlyTrucks)
            {
                truckHorsePower += item.HorsePower;
            }

            var averageCarsHorsePower = carsHorsePower / onlyCars.Count;
            var averageTrucksHorsePower = truckHorsePower / onlyTrucks.Count;
            
            if (onlyCars.Count != 0) Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsePower:f2}.");
            else Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            if (onlyTrucks.Count != 0) Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsePower:f2}.");
            else Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
        }
    }
    class Vehicle
    {
        public Vehicle()
        {
            Type = "";
            Model = "";
            Color = "";
            HorsePower = 0;
        }
        public Vehicle(string type, string model, string color, string horsePower)
        {
            Type = type.ToLower();
            Model = model;
            Color = color;
            HorsePower = int.Parse(horsePower);
        }
        public string Type;
        public string Model;
        public string Color;
        public int HorsePower;

        public override string ToString()
        {
            return $"Type: {(Type == "car" ? "Car" : "Truck")}{Environment.NewLine}"
                + $"Model: {Model}{Environment.NewLine}"
                + $"Color: {Color}{Environment.NewLine}"
                + $"Horsepower: {HorsePower}";
        }
    }
}
