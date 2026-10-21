using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19.dao
{
    internal class UtilityArrayConverter
    {
        public string[,] ArrayConvert(List<List<string>> list)
        {
            int rows = list.Count;
            int cols = list[0].Count;
            string[,] array = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = list[i][j];
                }
            }
            return array;
        }
    }
}
