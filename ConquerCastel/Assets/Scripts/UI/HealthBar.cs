using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Slider slider;

        public Image fill;

        public Gradient colorGradient;

        // Start is called before the first frame update
        public void SetHealth(float health)
        {
            slider.value = health;

            fill.color = colorGradient.Evaluate(slider.normalizedValue);
        }

        public void SetMaxHealth(float maxHealth)
        {
            slider.maxValue = maxHealth;
            slider.value = maxHealth;
            fill.color = colorGradient.Evaluate(1f);
        }
    }
}