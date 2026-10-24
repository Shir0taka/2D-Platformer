using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour
{
    [SerializeField] Slider healthSlider;
    [SerializeField] Player player;

    
    public void TakeDamage(int damage)
    {
        // Уменьшаем здоровье игрока на величину damage
        player.health -= damage;

        // Если здоровье стало отрицательным, устанавливаем его в 0
        if (player.health < 0)
        {
            player.health = 0;
        }

        // Обновляем значение healthSlider
        healthSlider.value = player.health;
    }
    
}
