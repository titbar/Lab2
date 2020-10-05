using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class TaskUtils
    {
        static public decimal CheapestFridgeWithFreezer(FridgesRegister register)
        {

            decimal smallestPrice = decimal.MaxValue;
            for (int i = 0; i < register.Count(); i++)
            {
                if (register.Get(i).HasFreezer == "turi šaldiklį")
                {
                    if (register.Get(i).Price < smallestPrice)
                    {
                        smallestPrice = register.Get(i).Price;
                    }
                }
            }

            return smallestPrice;
        }
        static public List<Fridge> ReturnFridgesListWithFreezer(decimal smallestPrice, FridgesRegister register, List<Fridge> cheapestFridge)
        {
            for (int i = 0; i < register.Count(); i++)
            {
                if (register.Get(i).HasFreezer == "turi šaldiklį")
                {
                    if (register.Get(i).Price == smallestPrice)
                    {
                        cheapestFridge.Add(register.Get(i));

                    }
                }
            }
            return cheapestFridge;
        }
    }
}
