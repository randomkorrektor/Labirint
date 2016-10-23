
using DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers
{
    public class LabyrinthManager
    {
        public static LabyrinthManager Instance = new LabyrinthManager();

        public Labyrinth labyrinth;

        public LabyrinthManager()
        {
            labyrinth = new Labyrinth();
        }
    }
}
