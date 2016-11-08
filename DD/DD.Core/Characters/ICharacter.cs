using System;
using System.Collections.Generic;
using System.Linq;
public interface ICharacter
{
    int Id { get; set; }
    string Name { get; set; }
    PlayableJob Job { get; set; }
    BaseStats Stats { get; set; }
    IEnumerable<IEquipable> Bag { get; set; }
    IEnumerable<ICard> Cards { get; set; }
    
}
