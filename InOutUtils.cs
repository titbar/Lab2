using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Main
{
    class InOutUtils
    {
        public static FridgesRegister ReadFridges(string fileName)
        {
            List<Fridge> fridges = new List<Fridge>();
            string[] Lines = File.ReadAllLines(fileName, System.Text.Encoding.UTF8);
            string NewShopsName = Lines[0];
            string NewShopsAdress = Lines[1];
            string NewShopsNumber = Lines[2];
            for (int i = 3; i < Lines.Length; i++)
            {
                string[] Values = Lines[i].Split(';');
                string NewManufacturer = Values[0];
                string NewModel = Values[1];
                double NewStorage = double.Parse(Values[2]);
                string NewEnergyCl = Values[3];
                string NewType = Values[4];
                string NewColour = Values[5];
                string NewHasFridge = Values[6];
                decimal NewPrice = decimal.Parse(Values[7]);

                Fridge fridge = new Fridge(NewManufacturer, NewModel, NewStorage, NewEnergyCl, NewType, NewColour, NewHasFridge, NewPrice);
                fridges.Add(fridge);
            }

            FridgesRegister register = new FridgesRegister(fridges, NewShopsName, NewShopsAdress, NewShopsNumber);
            
            return register;
        }
        public static void PrintInitialData(string fileName, FridgesRegister register)
        {
            string[] lines = new string[register.Count() + 9];
            lines[0] = String.Format(new string('-', 169));
            lines[1] = String.Format("|{0,-20}|{1,-20}", "Parduotuvė", register.ShopsName);
            lines[2] = String.Format(new string('-', 169));
            lines[3] = String.Format("|{0,-20}|{1,-20}", "Adresas", register.ShopsAdress);
            lines[4] = String.Format(new string('-', 169));
            lines[5] = String.Format("|{0,-20}|{1,-20}", "Parduodamų tel. nr.", register.ShopsNumber);
            lines[6] = String.Format(new string('-', 169));
            lines[7] = String.Format("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|",
                                     "Gamintojas", "Modelis", "Talpa", "Energijos klasė", "Montavimo tipas",
                                    "Spalva", "Ar turi šaldiklį?", "Kaina");
            for (int i = 0; i < register.Count(); i++)
            {
                lines[i + 8] = String.Format("|{0,-20}|{1,-20}|{2,20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,20}|",
                register.Get(i).Manufacturer, register.Get(i).Model, register.Get(i).Storage, register.Get(i).EnergyCl, register.Get(i).Type,
                register.Get(i).Colour, register.Get(i).HasFreezer, register.Get(i).Price);
            }
            lines[register.Count() + 8] = String.Format(new string('-', 169));
            File.AppendAllLines(fileName, lines, Encoding.UTF8);
        }
        public static void DisplayFridgesWithFreezer(List<Fridge> CheapestFridges) // pirmo punkto duomenu spausdinimas i ekrana
        {
            Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20}", "Parduotuvė", "Gamintojas", "Modelis", "Talpa", "Kaina");
            for (int i = 0; i < CheapestFridges.Count; i++)
            {
                Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20} {4,20}", CheapestFridges.
            }
            Console.WriteLine(new string('-', 169));
        }
    }
}
