using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingWire
{
    class PrejTelinZgjidhja
    {
        private int maxProfiti;
        private string zgjidhja;
        private int nrNdarjeve;
        private int gjatesiaNdarjes;

        public PrejTelinZgjidhja(int maxProfiti, string zgjidhja, int nrNdarjeve, int gjatesiaNdarjes)
        {
            this.maxProfiti = maxProfiti;
            this.zgjidhja = zgjidhja;
            this.nrNdarjeve = nrNdarjeve;
            this.gjatesiaNdarjes = gjatesiaNdarjes;
        }

        public PrejTelinZgjidhja()
        {
        }

        public int getMaxProfiti()
        {
            return maxProfiti;
        }

        public string getZgjidhja()
        {
            return zgjidhja;
        }

        public int getNrNdarjeve()
        {
            return nrNdarjeve;
        }

        public int getGjatesiaNdarjes()
        {
            return gjatesiaNdarjes;
        }
    }
}
