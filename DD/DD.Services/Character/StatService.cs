using System;
using System.Linq;
public static class StatService
{
    
    public static int GetAttack(ICharacter character)
    {
        var weaponBonus = character.Bag.Single(x => x is Weapon && x.IsEquiped == true).Bonus;
            
        return character.Stats.Attack + weaponBonus;

    }

    public static int GetDefense(ICharacter character)
    {
        var armorBonus = character.Bag.Single(
        x => x is Armor && x.IsEquiped == true).Bonus;

        var defense = character.Stats.Defense / 2;

        return defense + armorBonus;
    }

    public static int GetHitPoints(ICharacter character)
    {
        var lifeBonus = character.Bag.Single(
        x => x is Ring && x.IsEquiped == true).Bonus;

        var hitPoints = character.Stats.HitPoints * 2 + 10;

        return hitPoints + lifeBonus;
    }

    public static int GetMovement(ICharacter character)
    {
        var moveBonus = character.Bag.Single(
        x => x is Feet && x.IsEquiped == true).Bonus;

        var movement = character.Stats.Movement / 3;

        return movement + moveBonus;
    }

    public static int GetRecovery(ICharacter character)
    {
        var recoveryBonus = character.Bag.Single(
        x => x is Ring && x.IsEquiped == true).Bonus;

        return character.Stats.HitPoints * 3 + recoveryBonus;
    }
}