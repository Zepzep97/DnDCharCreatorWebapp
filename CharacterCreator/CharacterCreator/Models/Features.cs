using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public enum Sex
    {
        Male, Female
    }
    public class Features
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Sex? Sex { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Inteligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }
}
