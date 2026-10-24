using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using Photon.Pun;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Сериализованные поля
    [SerializeField] Slider healthSlider;
    [SerializeField] SaveSystem saveLoad;

    // Объекты класса
    PlayerMovement movement;
    PhotonView view;
    Vector2 moveInput;
    Vector2 moveAmount;
    SpawnPlayers spawn;
    DamageButton damage;
    Vector2 position;

    // Поля
    public int health;
    

    // Игра началась
    private void Start()
    {
        view = GetComponent<PhotonView>();

        

        health = 4;

        // Находим объект Player(Clone) в сцене
        position = transform.position;
    }

    // Игра продолжается
    void Update()
    {
        /*if (view.IsMine)
        {
            moveInput = new Vector2(
                Input.GetAxisRaw("Horizontal"),
                Input.GetAxisRaw("Vertical")
            );
            moveAmount = moveInput.normalized * movement.speed * movement.jumpForce * Time.deltaTime;
            transform.position += (Vector3)moveAmount;
             // Обновляем текущую позицию игрока
        }*/
        
        position = transform.position;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SavePlayer(0);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            LoadPlayer(0);
        }
    }

    // Ваш код управления клоном
    void UpdateClone()
    {
        if (!view.IsMine)
        {
            // Дополнительные действия для клонов
        }
    }

    static string savePath = Application.dataPath + "/Scripts/Savings/";

    string[] saveJson =
    {
        savePath + "/saveState0.json",
        savePath + "/saveState1.json",
        savePath + "/saveState2.json",
        savePath + "/saveState3.json",
        savePath + "/saveState4.json"
    };

    // Сохранение
    public void SavePlayer(int saveSlot)
    {
        SaveSystem.Save(new PlayerData(health, position), saveJson[saveSlot]);
    }

    // Загрузка
    public void LoadPlayer(int saveSlot)
    {
        PlayerData loadedData = SaveSystem.Load<PlayerData>(saveJson[saveSlot]);
        health = loadedData.health;
        position = loadedData.position;
        healthSlider.value = health;
        transform.position = position;
    }
}
