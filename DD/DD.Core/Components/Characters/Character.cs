using System;
using System.Collections.Generic;
using DD.Core.Components.Characters.Jobs;
using Stats;

namespace DD.Core.Components.Characters
{
    public abstract class Character : ICharacter
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IJob Job { get; set; }
        public BaseStats Stats { get; set; }
        public IEnumerable<IEquipment> Bag { get; set; }
        public IEnumerable<ICard> Cards { get; set; }

        public virtual void LevelUp()
        {
            Job.LevelUp();
        }
    }
}