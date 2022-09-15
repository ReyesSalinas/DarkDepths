using Assets.Scripts.Core.Character;
using Engine.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.HUD
{
    public class TargetInfo : MonoBehaviour
    {
        [SerializeField] GameObject text;
        [SerializeField] GameObject healthBar;

        // Start is called before the first frame update
        void Start()
        {
            HideTargetInfo();
            var player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<PlayerController>().onTargetHover = ShowTargetInfo;
            

        }

        // Update is called once per frame
        void ShowTargetInfo(GameObject target)
        {
            if(target == null)
            {
                HideTargetInfo();
                return;
            }
            text.GetComponent<Text>().text = target.GetComponent<Character>().Name;
            healthBar.GetComponent<TargetHealthDisplay>().SetHealthForTarget(target);
            target.GetComponent<Health>().onDeath = HideTargetInfo;

            text.SetActive(true);
            healthBar.SetActive(true);
        }

        void HideTargetInfo()
        {
            text.name = string.Empty;
            text.SetActive(false);
            healthBar.SetActive(false);
        }
       
    }
}

