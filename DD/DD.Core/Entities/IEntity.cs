using System;

namespace DD.Core.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
        string Name { get; set; }
        void Update();
    }
}