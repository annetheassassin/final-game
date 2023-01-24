using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider Slider;
    public Color Low;
    public Color High;
    public Vector3 Offset;

    public void SetHealth(float health, float MaxHealth)
    {
        Slider.gameObject.SetActive(health < MaxHealth);
        Slider.value = health;
        Slider.maxValue = MaxHealth;
        Debug.Log(Slider.value.ToString() + " " + Slider.maxValue.ToString());


        Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, Slider.normalizedValue);
    }

    void FixedUpdate()
    {
        Slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + Offset);
    }
}
