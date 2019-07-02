using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryKeeper.DaraBaseTablesClassses
{
    public class Memory:EntityBase
    {
        public Memory()
        {
            Rate = 0;
        }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Rate { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
