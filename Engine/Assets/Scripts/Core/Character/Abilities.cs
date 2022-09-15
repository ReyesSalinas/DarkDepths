using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Character.Stats
{
    public enum AbilityNames
    {
        Strength,
        Dexterity,
        Intelligence,
        Wisdom,
        Charisma,
        Luck
    }

    public class Abilities : MonoBehaviour
    {
        // Start is called before the first frame update
        public int Strength;
        public int Dexterity;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;
        public int Luck;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void IncreaseStat(int amount, AbilityNames stat)
        {
            switch (stat)
            {
                case AbilityNames.Strength:
                    this.Strength += amount;
                    break;
                case AbilityNames.Dexterity:
                    this.Dexterity += amount;
                    break;
                case AbilityNames.Intelligence:
                    this.Intelligence += amount;
                    break;
                case AbilityNames.Wisdom:
                    this.Wisdom += amount;
                    break;
                case AbilityNames.Charisma:
                    this.Charisma += amount;
                    break;
                case AbilityNames.Luck:
                    this.Luck += amount;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(stat), stat, null);
            }
        }
    }
}

