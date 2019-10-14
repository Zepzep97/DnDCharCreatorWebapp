using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string Name { get; set; }

        public List<Characters> Characters { get; set; }
    }
}
