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
    }
}
