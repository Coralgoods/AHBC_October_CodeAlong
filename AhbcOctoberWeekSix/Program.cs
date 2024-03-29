﻿using System;
using System.Collections.Generic;

namespace AhbcOctoberWeekSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TurboCar fastCar = new TurboCar() { CurrentAcceleration = 40 };

            IncreaseSpeed(fastCar, 25);
            DisplaySpeed(fastCar);

            OffRoadCar jeep = new OffRoadCar() { CurrentAcceleration = 30 };
            IncreaseSpeed(jeep, 5);

            Car thisCar = new Car() { CurrentAcceleration = 15 };
            //DisplayAltitude(thisCar);
            Car newCar = new Car();
            CarDealership myDealership = new CarDealership(newCar);

            List<IPerson> employeeList = new List<IPerson>();
            List<IPerson> customers = new List<IPerson>();

            myDealership.GetNames(employeeList);
            myDealership.GetNames(customers);
        }

        static void IncreaseSpeed(Car car, double speed)
        {
            car.Accelerate(speed);
        }
        static void DisplaySpeed(Car car)
        {
            Console.WriteLine(car.CurrentAcceleration);
        }

        static void DisplayAltitude(OffRoadCar car)
        {
            Console.WriteLine(car.CurrentAltitude);
        }
    }
}
