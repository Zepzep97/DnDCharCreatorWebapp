using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public enum Race
    {
        Dragonborn,
        Dwarf,
        Elf,
        Gnome,
        HalfElf,
        Halfling,
        HalfOrc,
        Human,
        Tiefling,
        Arakocra,
        Genasi,
        Goliath,
        Aasimar,
        Bugbear,
        Firbolg,
        Goblin,
        Hobgoblin,
        Kenku,
        Kobold,
        Lizardfolk,
        Orc,
        Tabaxi,
        Triton
    }
    public class Heritage
    {
        public Race? Race { get; set; }
    }
}
