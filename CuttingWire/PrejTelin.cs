using System;

namespace CuttingWire
{
    class PrejTelin
    {
        public int prej(int[] cmimet, int gjatesia)
        {
            int[] rezultati = new int[gjatesia + 1];
            rezultati[0] = 0;

            for (int i = 1; i <= gjatesia; i++)
            {
                int max_val = int.MinValue;
                for (int j = 0; j < i; j++)
                {
                    max_val = Math.Max(max_val, cmimet[j] + rezultati[i - j - 1]);
                } 
                rezultati[i] = max_val;
            }
            return rezultati[gjatesia];
        }
    }
}
