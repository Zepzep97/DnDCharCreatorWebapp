﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{

    public class Characters
    {
        public int CharactersId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Alignment { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public Class Class { get; set; }
        public int ClassId { get; set; }

        public Race Race { get; set; }
        public int RaceId { get; set; }
    }
}
