using CarRental.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Enums
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Km { get; set; }
        public DateTime ProductTime { get; set; }
        public Status Status { get; set; }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public Car(string brand, string model, int km, DateTime productTime, Status status)
        {
            Brand = brand;
            Model = model;
            Km = km;
            ProductTime = productTime;
            Status = status;
        }


        public Car()
        {
        }
    }

}
