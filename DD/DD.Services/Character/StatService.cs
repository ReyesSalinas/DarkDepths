using System.Linq;
using DD.Core.Components.Characters;

public static class StatService
{
    public static float GetAttack(ICharacter character)
    {
        var weaponBonus = character.Bag.Single(
            x => x is Weapon && x.IsEquiped).Bonus;

        return character.Stats.Attack + weaponBonus;
    }

    public static float GetDefense(ICharacter character)
    {
        var armorBonus = character.Bag.Single(
            x => x is Armor && x.IsEquiped).Bonus;

        var defense = character.Stats.Defense / 2;

        return defense + armorBonus;
    }

    public static float GetHitPoints(ICharacter character)
    {
        var lifeBonus = character.Bag.Single(
            x => x is Ring && x.IsEquiped).Bonus;

        var hitPoints = character.Stats.HitPoints * 2 + 10;

        return hitPoints + lifeBonus;
    }

    public static float GetMovement(ICharacter character)
    {
        var moveBonus = character.Bag.Single(
            x => x is Feet && x.IsEquiped).Bonus;

        var movement = character.Stats.Movement / 3;

        return movement + moveBonus;
    }

    public static float GetRecovery(ICharacter character)
    {
        var recoveryBonus = character.Bag.Single(
            x => x is Ring && x.IsEquiped).Bonus;

        return character.Stats.HitPoints * 3 + recoveryBonus;
    }
}