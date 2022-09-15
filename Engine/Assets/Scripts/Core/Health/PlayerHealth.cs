using Assets.Scripts.Handlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Character
{
    public class PlayerHealth : Health
    {
        // Start is called before the first frame update
        public override void Start()
        {
            base.Start();
            GetComponent<PlayerControlledCharacter>().onLevelUp += LevelUp;
        }
   
        void LevelUp()
        {
            print("Level Up set health to 1000");
            amount = GetComponent<Character>().HitPoints();
        }
    }
}

