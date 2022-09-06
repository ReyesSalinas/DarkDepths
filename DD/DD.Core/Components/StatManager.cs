using System;
using DD.Core.Components.Characters;
using DD.Core.Components.Characters.Stats;

namespace DD.Core.Components
{
    public class StatManager
    {
        public void IncreaseStat(PlayerCharacter character, StatNames stat)
        {
            switch (stat)
            {
                case StatNames.Attack:
                    character.Stats.Attack += 1;
                    break;
                case StatNames.Defense:
                    character.Stats.Defense += 1;
                    break;
                case StatNames.HitPoints:
                    character.Stats.HitPoints += 1;
                    break;
                case StatNames.Movement:
                    character.Stats.Movement += 1;
                    break;
            }
            character.SubtractStatPoints(1);
        }
    }
}