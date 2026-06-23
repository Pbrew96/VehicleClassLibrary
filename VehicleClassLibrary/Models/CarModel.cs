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
    public class CarModel : VehicleModel
    {
        // Class level properties
        public bool IsConvertible { get; set; }
        public decimal TrunkSize { get; set; } // In cubic feet

        /// <summary>
        /// Default Constructor for the car model
        /// </summary>
        public CarModel() : base()
        {
            IsConvertible = false;
            TrunkSize = 0m;
        }

        /// <summary>
        /// Parameterized constructor for a car model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="price"></param>
        /// <param name="numWheels"></param>
        public CarModel(
    int id,
    string make,
    string model,
    int year,
    decimal price,
    int numWheels,
    string color,
    bool isNew,
    bool isConvertible,
    decimal trunkSize)
    : base(id, make, model, year, price, numWheels, color, isNew)
        {
            IsConvertible = isConvertible;
            TrunkSize = trunkSize;
        }

        public override string ToString()
        {
            //use a ternary operator (in-line if) to get the convertible string
            //                      condition     if true    if false
            string convertible = IsConvertible ? "with" : "without";

            string newStatus = IsNew ? "New" : "Used";

            // Print the car in the following format
            // 1: 2019 Jeep Wrangler with 4 wheels and a 14.7 cubic foot trunk with(out_ a convertible top - $27000.00
            return $"{Id}: {Year} {Color} {Make} {Model} ({newStatus}) with {NumWheels} wheels and a {TrunkSize} cubic foot trunk {convertible} a convertible top - {Price:C2}";
        }
    }
}
