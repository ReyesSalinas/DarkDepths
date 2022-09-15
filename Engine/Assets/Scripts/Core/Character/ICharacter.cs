using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Character.Stats;
using Assets.Scripts.Core.Jobs;
using Assets.Scripts.Core.Item;
namespace Assets.Scripts.Core.Character
{
    public interface ICharacter
    {
        Guid Id { get; set; }
        string Name { get; set; }
        IJob Job { get; set; }
    }
}