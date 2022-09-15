using Assets.Scripts.Combat;
using Assets.Scripts.Core.Character;
using Assets.Scripts.Handlers;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.HUD
{
    public class HealthDisplay : MonoBehaviour
    {
        
        protected Health health;
        float maxHitPoint;
        public Image currentHealthBar;
        public Text healthText;
        float width;
        // Use this for initialization

        protected virtual void Start()
        {
           
            width += currentHealthBar.rectTransform.rect.width;
          
        }      
             
        protected void UpdateMaxHealth(GameObject gameObject)
        {           
            maxHitPoint = gameObject.GetComponent<Character>().HitPoints();
            GetComponentInChildren<Text>().text = maxHitPoint.ToString();
        }

        protected void UpdateHealthBar()
        {
            
            float ratio = health.GetCurrentHealth() / maxHitPoint;
            currentHealthBar.rectTransform.localPosition = new Vector3(width * ratio - width, 0, 0);
            healthText.text = health.GetCurrentHealth().ToString("0") + "/" + maxHitPoint.ToString("0");
        }
    }
}