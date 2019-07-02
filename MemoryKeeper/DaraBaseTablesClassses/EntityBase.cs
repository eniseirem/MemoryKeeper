
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryKeeper.DaraBaseTablesClassses
{
    public class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
