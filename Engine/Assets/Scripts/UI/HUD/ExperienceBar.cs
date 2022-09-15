using Assets.Scripts.Core.Character;
using Assets.Scripts.Handlers;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.HUD
{
    public class ExperienceBar : MonoBehaviour
    {
        public Image currentExperienceBar;
        public Text experienceText;
        private float barWidth;

        // Use this for initialization
        void Start()
        {
            var experienceHandler = GameObject.FindWithTag("Player").GetComponent<Experience>();
            experienceHandler.onExperienceGained = UpdateExperienceBar;
            barWidth += currentExperienceBar.rectTransform.rect.width;
        }

        // Update is called once per frame      
        private void UpdateExperienceBar(float currentExperience, float experienceForNextLevel)
        {
            float ratio = currentExperience / experienceForNextLevel;
            currentExperienceBar.rectTransform.localPosition = new Vector3(barWidth * ratio - barWidth, 0, 0);
            experienceText.text = currentExperience.ToString("0") + "/" + experienceForNextLevel.ToString("0");
        }
    }
}