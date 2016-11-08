using System;
using System.Linq;
public interface IEquipable: IGameItem
{
    bool IsEquiped { get; set; }
    int Bonus { get; set; }
}
