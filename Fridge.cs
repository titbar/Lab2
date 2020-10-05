using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Fridge
    {
        public string Manufacturer { get; set; } /// Fridge's manufacturer's name
        public string Model { get; set; } /// Fridge's model's name
        public double Storage { get; set; } /// Fridge's storage
        public string EnergyCl { get; set; } /// Fridge's energy class
        public string Type { get; set; } /// Fridge's type
        public string Colour { get; set; } /// Fridge's colour
        public string HasFreezer { get; set; } /// Fridge has got or hasn't got a freezer
        public decimal Price { get; set; } /// Freezer's price

        public Fridge(string NewManufacturer, string NewModel, double NewStorage, string NewEnergyCl, string NewType, string NewColour, string NewHasFreezer, decimal NewPrice)
        {
            this.Manufacturer = NewManufacturer;
            this.Model = NewModel;
            this.Storage = NewStorage;
            this.EnergyCl = NewEnergyCl;
            this.Type = NewType;
            this.Colour = NewColour;
            this.HasFreezer = NewHasFreezer;
            this.Price = NewPrice;
        }
    }
}
