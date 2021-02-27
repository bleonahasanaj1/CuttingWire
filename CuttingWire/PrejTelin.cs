using System;
using System.Collections.Generic;

namespace CuttingWire
{
    class PrejTelin
    {
        string zgjidhja;
        int nrNdarjeve = 0;
        int gjatesiaNdarjes = 0;

        public PrejTelinZgjidhja Prej(int[] cmimet, int gjatesia)
        {
            return new PrejTelinZgjidhja(gjejVlerenMaksimale(cmimet, gjatesia), zgjidhja, nrNdarjeve, gjatesiaNdarjes);
        }

        private int gjejVlerenMaksimale(int[] cmimet, int gjatesia)
        {
            if (gjatesia <= 0)
                return 0;

            int[] rezultatet = new int[gjatesia + 1];
            rezultatet[0] = 0;
            int vleraAktuale = rezultatet[0];

            for (int i = 1; i <= gjatesia; i++)
            {
                int vleraMaksimale = int.MinValue;
                for (int j = 0; j < i; j++)
                {
                    vleraMaksimale = Math.Max(vleraMaksimale, cmimet[j] + rezultatet[i - j - 1]);

                    if (vleraAktuale != vleraMaksimale || vleraAktuale == 0)
                    {
                        List<int> listaRastet = new List<int>();
                        listaRastet.Add(cmimet[j]);
                        listaRastet.Add(rezultatet[i - j - 1]);
                        vleraAktuale = vleraMaksimale;
                        int[] varguRastet = listaRastet.ToArray();
                        zgjidhja = GjejZgjidhjen(varguRastet);
                    }
                }
                rezultatet[i] = vleraMaksimale;
            }
            return rezultatet[gjatesia];
        }

        private string GjejZgjidhjen(int[] nenProblemet)
        {
            string zgj = string.Empty;
          
            for (int i = 0; i < nenProblemet.Length; i++)
            {
                if (i != nenProblemet.Length - 1)
                {
                    zgj += nenProblemet[i] + " + ";
                }
                else if (i == nenProblemet.Length - 1)
                {
                    zgj += nenProblemet[i];
                }

                gjatesiaNdarjes = nenProblemet[i];
            }
            nrNdarjeve = nenProblemet.Length;

            return zgj;
        }
    } 
}

        