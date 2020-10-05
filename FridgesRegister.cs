using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class FridgesRegister
    {
        private List<Fridge> allFridges = new List<Fridge>();

        public string ShopsName { get; set; } // Shop's name
        public string ShopsAdress { get; set; } // Shop's location
        public string ShopsNumber { get; set; } // Shop's phone number

        public FridgesRegister(List<Fridge> fridges, string NewShopsName, string NewShopsAdress, string NewShopsNumber)
        {
            this.ShopsName = NewShopsName;  /// same meanings, in order
            this.ShopsAdress = NewShopsAdress;
            this.ShopsNumber = NewShopsNumber;

            foreach (Fridge fridge in fridges)
            {
                this.allFridges.Add(fridge);
            }
        }

        public int Count()
        {
            return this.allFridges.Count;
        }

        public Fridge Get(int index)
        {
            return this.allFridges[index];
        }

        public void Add(Fridge fridge)
        {
            this.allFridges.Add(fridge);
        }

    }
}
