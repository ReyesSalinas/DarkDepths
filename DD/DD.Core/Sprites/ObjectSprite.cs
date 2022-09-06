using System;

namespace DD.Core.Sprites
{
    public class ObjectSprite : ISprite
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}