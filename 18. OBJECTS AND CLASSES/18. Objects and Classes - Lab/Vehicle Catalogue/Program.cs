using System;
using System.Collections.Generic;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var cars = new List<Car>();
            var trucks = new List<Truck>();
            while (input.ToLower()!="end")
            {
                var newInput = input.Split('/');
                if (newInput[0] == "Car")
                {
                    cars.Add(new Car(newInput[1], newInput[2], int.Parse(newInput[3])));
                }
                else
                {
                    trucks.Add(new Truck(newInput[1], newInput[2], int.Parse(newInput[3])));
                }
                input = Console.ReadLine();
            }
            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                var newCars = new List<Car>();
                var minLetter = 123;
                var minItem = new Car();
                var maxI = cars.Count;
                for (int i = 0; i < maxI; i++)
                {
                    foreach (var item in cars)
                    {
                        if (item.Brand[0] < minLetter)
                        {
                            minLetter = item.Brand[0];
                            minItem = item;
                        }
                    }
                    newCars.Add(minItem);
                    cars.Remove(minItem);
                    minLetter = 123;
                }
                foreach (var item in newCars)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                var newTrucks = new List<Truck>();
                var minLetter = 123;
                var minItem = new Truck();
                var maxI = trucks.Count;
                for (int i = 0; i < maxI; i++)
                {
                    foreach (var item in trucks)
                    {
                        if (item.Brand[0] < minLetter)
                        {
                            minLetter = item.Brand[0];
                            minItem = item;
                        }
                    }
                    newTrucks.Add(minItem);
                    trucks.Remove(minItem);
                    minLetter = 123;
                }
                foreach (var item in newTrucks)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
        }
    }
    class Car
    {
        public Car()
        {
            Brand = "";
            Model = "";
            HorsePower = 0;
        }
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand;
        public string Model;
        public int HorsePower;
    }
    class Truck
    {
        public Truck()
        {
            Brand = "";
            Model = "";
            Weight = 0;
        }
        public Truck(string brand,string model,int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand;
        public string Model;
        public int Weight;
    }
    class Catalog
    {
        public List<Car> cars;
        public List<Truck> trucks;
    }
}
