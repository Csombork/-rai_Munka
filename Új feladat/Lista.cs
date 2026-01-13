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

        public void Hozzáadás(int adat)
        {
            if (táelmszám + 1 > kapacitás)
            {
                kapacitás = kapacitás * 2;
                int[] mentés = new int[kapacitás];
                for (int i = 0; i < táelmszám; i++)
                {
                    mentés[i] = tomb[i]; 
                }
                tomb = mentés;
            }
            tomb[táelmszám] = adat;
            táelmszám++;
        }

        public int Kiír(int hanyelem)
        {
            return tomb[hanyelem];
        }
    }
}
