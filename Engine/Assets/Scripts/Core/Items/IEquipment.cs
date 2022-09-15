namespace Assets.Scripts.Core.Item
{
    public interface IEquipment : IGameItem
    {
        bool IsEquiped { get; set; }
    }
}
