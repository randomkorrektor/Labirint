using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTipes
{
    public class Labirint
    {
        public bool[,] grid;

        public bool GetPoint(int x, int y)
        {
            return grid[x, y];
        }
    }
}
