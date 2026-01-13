using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Új_feladat
{
    internal class Lista
    {
        // privát mezők
        private int[] tomb;

        private int kapacitás;

        private int táelmszám;

        // Tömb létrehozása és méretének megadása
        public Lista(int kapacitás = 2)
        {
            this.kapacitás = kapacitás;
            this.táelmszám = 0;
            this.tomb = new int[kapacitás];
        }

        public void Hozzáadás(int adat) // Hozzá adsz egy számot a tömbhöz
        {
            if (táelmszám + 1 > kapacitás)
            {
                Bővítés();
            }
            tomb[táelmszám] = adat;
            táelmszám++;
        }

        
        private void Bővítés() // Rejtett segéd fügvény
        {
            kapacitás = kapacitás * 2;
            int[] mentés = new int[kapacitás];
            for (int i = 0; i < táelmszám; i++)
            {
                mentés[i] = tomb[i];
            }
            tomb = mentés;
        }

        public int Kiír(int hanyelem)
        {
            return tomb[hanyelem];
        }

        public void TötölAdottÉrtéket()
        {

        }

        public void TötölAdottIndexet()
        {

        }

        public void Rendez(int valami)
        {

        }

        public void Hozzáadás(int[] uj)
        {
            foreach (var item in uj)
            {
                Hozzáadás(item);
            }
        }

        public void Kiürít()
        {
            tomb = new int[kapacitás];
            táelmszám = 0;
        }

        public int Osszeg()
        {
            int összeg = 0;
            for (int i = 0; i < táelmszám; i++)
            {
                összeg += tomb[i];
            }
            return összeg;
        }

        public bool Tartalmaz(int keresett)
        {
            for (int i = 0; i < táelmszám; i++)
            {
                if (tomb[i] == keresett)
                {
                    return true;
                }
            }
            return false;
        }

        public int Index(int keresett)
        {
            /// <summary>
            /// Megkeresi az indexét a megadott
            /// számnak
            /// </summary>
            for (int i = 0; i < táelmszám; i++)
            {
                if (tomb[i] == keresett)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
