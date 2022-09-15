using System;
using System.Collections.Generic;
using DD.Core.Components.Characters.Jobs;
using Stats;

namespace DD.Core.Components.Characters
{
    public interface ICharacter
    {
        Guid Id { get; set; }
        string Name { get; set; }
        IJob Job { get; set; }
        BaseStats Stats { get; set; }
        IEnumerable<IEquipment> Bag { get; set; }
        IEnumerable<ICard> Cards { get; set; }
    }
}