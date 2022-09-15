using System;

namespace DD.Core.Sprites
{
    public interface ISprite
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
    }
}