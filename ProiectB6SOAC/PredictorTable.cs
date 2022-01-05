using System;

namespace ProiectB6SOAC
{
    public class PredictorTable
    {
        public int[] table;

        public PredictorTable(int _tableLen, Random random)
        {
            table = new int[_tableLen];
            for (int i = 0; i < _tableLen; i++)
                table[i] = random.Next(-1, 2);
        }
    }
}