using System;
using System.Linq;
public interface IEquipment : IGameItem
{
    bool IsEquiped { get; set; }
}
