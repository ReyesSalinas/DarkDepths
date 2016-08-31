using System;
using System.Linq;
public class Weapon : IEquipment
{
    public int Bonus { get; set; }
    public int Id { get; set; }
    public bool IsEquiped { get; set; }
    public string Name { get; set; }
}
