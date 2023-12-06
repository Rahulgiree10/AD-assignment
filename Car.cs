using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Car
    {
        private String brand;
        private int year;
        private float price;
    }

    public static void main(String args) {
        Car car = new Car("Thar",2020,4000000.0f);
        Console.WriteLine("Brand: "car.brand, ",Year: "car.year,", and Price: "car.price);
    }
}
