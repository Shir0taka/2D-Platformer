using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int health;
    
    public Vector2 position;

    public PlayerData(int health, Vector2 position)
    {
        
        this.health = health;
        this.position = position;
    }
}
