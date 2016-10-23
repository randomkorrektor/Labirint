using DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagers
{
    public class LabyrinthManager
    {
        public static LabyrinthManager Instance = new LabyrinthManager();

        private LabyrinthManager() { }

        public Queue<Step> queue;

        public Cell[]  getCell(Position pos)
        {
            return null;
        }

        public bool find()
        {
            var step = queue.Dequeue();

            var cells = getCell(step.pos);

            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i].Type == CellType.Exit)

                {
                    return true;
                }

                if (cells[i].Type == CellType.Floor)
                {
                    queue.Enqueue(new Step(step, cells[i].Position));
                }
            }

            return false;
        }
    }
}
