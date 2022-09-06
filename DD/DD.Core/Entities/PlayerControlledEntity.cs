using System;
using DD.Core.Components.Characters;

namespace DD.Core.Entities
{
    public class PlayerControlledEntity : IEntity
    {
        public Character Character { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Update()
        {
        }
    }
}