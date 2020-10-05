//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// U2-22.Buitinės technikos parduotuvė. 
// Turite informaciją apie dvejose buitinės technikos parduotuvėse esančius šaldytuvus. 
// Keičiasi duomenų formatas. Pirmoje eilutėje pavadinimas, antroje –adresas, trečioje –telefonas. 
// Toliau informacija apie šaldytuvus pateikta tokiu pačiu formatu kaip L1 užduotyje.
// • Raskite  pigiausią  pastatomą  šaldytuvą,  turintį  šaldiklį,  ekrane  atspausdinkite  kuriose parduotuvėse galima jį įsigyti, jo gamintoją, modelį, talpą ir kainą. Jei yra keli, spausdinkite visus
// • Suraskite,  kurio  gamintojo šaldytuvai yra  brangiausi  kiekvienoje  parduotuvėje  atskirai, rezultatą atspausdinkite ekrane 
// • Ar yra tokių šaldytuvų, kuriuos galima įsigyti abejose parduotuvėse? Atspausdinkite tokių šaldytuvų sąrašą faile „Abi.csv“.
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            FridgesRegister register1 = InOutUtils.ReadFridges(@"Parduotuvė1.txt");
            FridgesRegister register2 = InOutUtils.ReadFridges(@"Parduotuvė2.txt");
            string fileName = "Rezults.txt";
            InOutUtils.PrintInitialData(fileName, register1);
            InOutUtils.PrintInitialData(fileName, register2);
            decimal CheapestFridge1 = TaskUtils.CheapestFridgeWithFreezer(register1);
            decimal CheapestFridge2 = TaskUtils.CheapestFridgeWithFreezer(register2);
            List<Fridge> CheapestFridges = new List<Fridge>();
            if (CheapestFridge1 > CheapestFridge2) // pirmas punktas
            {
                CheapestFridges = TaskUtils.ReturnFridgesListWithFreezer(CheapestFridge1, register1, CheapestFridges);
                Console.WriteLine(new string('-', 169));
                Console.WriteLine("Pigiausias šaldytuvas/-ai");
                Console.WriteLine(new string('-', 169));
                InOutUtils.DisplayFridgesWithFreezer(CheapestFridges);
            }
            else if (CheapestFridge2 > CheapestFridge1)
            {
                CheapestFridges = TaskUtils.ReturnFridgesListWithFreezer(CheapestFridge2, register2, CheapestFridges);
                Console.WriteLine(new string('-', 169));
                Console.WriteLine("Pigiausias šaldytuvas/-ai");
                Console.WriteLine(new string('-', 169));
                InOutUtils.DisplayFridgesWithFreezer(CheapestFridges);
            }
            else
            {
                Console.WriteLine(new string('-', 169));
                Console.WriteLine("Pigiausias šaldytuvas/-ai");
                Console.WriteLine(new string('-', 169));
                CheapestFridges = TaskUtils.ReturnFridgesListWithFreezer(CheapestFridge1, register1, CheapestFridges);
                InOutUtils.DisplayFridgesWithFreezer(CheapestFridges);
                CheapestFridges = TaskUtils.ReturnFridgesListWithFreezer(CheapestFridge2, register2, CheapestFridges);
                InOutUtils.DisplayFridgesWithFreezer(CheapestFridges);

            }
        }
    }
}
