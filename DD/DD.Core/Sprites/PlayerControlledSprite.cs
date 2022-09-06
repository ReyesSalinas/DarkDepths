using System;

namespace DD.Core.Sprites
{
    internal class PlayerControlledSprite : ISprite
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}