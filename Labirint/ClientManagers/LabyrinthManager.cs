using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagers
{
    public struct Pos
    {
        public int x;
        public int y;
    }
    public class LabyrinthManager
    {
        public static LabyrinthManager Instance = new LabyrinthManager();

        private LabyrinthManager() { }

        public Queue<Pos> queue;

        public bool[,]  getCell()
        {
            return null;
        }

        public void find()
        {

        }
    }
}
