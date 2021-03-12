using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst_BackEnd.DataAccess
{
    public class Carreer
    {
        public int CarreerID { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Type { get; set; }
        public string Plan { get; set; }

        public ICollection<Students> Students { get; set; }

    }
}
