namespace Assets.Scripts.Core.Item
{
    public class Ring : IEquipment
    {
        public int Bonus { get; set; }
        public int Id { get; set; }
        public bool IsEquiped { get; set; }
        public string Name { get; set; }
    }
}