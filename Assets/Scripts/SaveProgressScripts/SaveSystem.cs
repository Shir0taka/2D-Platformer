using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using Unity.VisualScripting;

[System.Serializable]
public class SaveSystem : IInitializable {
    public static JsonSerializerSettings _jsonSettings = new();

    public void Initialize() {
        _jsonSettings.Formatting = Formatting.Indented;
    }

    public static void Save<T>(T objectToSave, string destination) {
        string jsonString = JsonConvert.SerializeObject(objectToSave, _jsonSettings);
        File.WriteAllText(destination, jsonString);
    }

    public static T Load<T>(string destination) {
        string jsonString = File.ReadAllText(destination);
        var objectToLoad = JsonConvert.DeserializeObject<T>(jsonString);
        
        return objectToLoad;
    }

}