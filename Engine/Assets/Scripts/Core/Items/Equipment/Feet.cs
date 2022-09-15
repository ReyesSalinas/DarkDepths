namespace Assets.Scripts.Core.Item
{
    public class Feet : IEquipment
    {
        public int Bonus { get; set; }
        public int Id { get; set; }
        public bool IsEquiped { get; set; }
        public string Name { get; set; }
    }
}