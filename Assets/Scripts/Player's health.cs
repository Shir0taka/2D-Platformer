using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] public Slider slider;

    public void UpdateHealthBar(float currentHp) {
        slider.value = currentHp;
    }

}
