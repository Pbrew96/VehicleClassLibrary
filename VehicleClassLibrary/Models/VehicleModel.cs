/*
 * Patrick Brewster
 * CST - 250
 * 06/20/2026
 * Vehicle Class Library
 * Activity 1
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleClassLibrary.Models
{
    public class VehicleModel
    {
        // Class level properties
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int NumWheels { get; set; }
        public string Color { get; set; }
        public bool IsNew { get; set; }

        /// <summary>
        /// Default Constructor a vehicle model
        /// </summary>
        public VehicleModel()
        {
            Id = 0;
            Make = "Unknown";
            Model = "Unknown";
            Year = 0;
            Price = 0m;
            NumWheels = 0;
            Color = "Unknown";
            IsNew = false;
        }
        /// <summary>
        /// Parameterized constructo for the vehicle model class
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        public VehicleModel(int id, string make, string model,
     int year, decimal price, int numWheels,
     string color, bool isNew)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            NumWheels = numWheels;
            Color = color;
            IsNew = isNew;
        }
        public override string ToString()
        {
            string newStatus = IsNew ? "New" : "Used";
            //Print the vehicle in the following format
            // 1: 2013 Ford Fiesta with 4 wheels - $800.00
            return $"{Id}: {Year} {Color} {Make} {Model} ({newStatus}) with {NumWheels} wheels - {Price:C2}";
        }
    }
}
