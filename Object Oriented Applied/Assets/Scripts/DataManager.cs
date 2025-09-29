using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance; //My permanent inherited field.
    // My saved fields.
    public string PlayerName;
    public float VolumeSetting;
    public float BestTimeLasted;
    public int GameDifficulty;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject); //Remove if not null.
            return;
        }
        Instance = this; //sets the instance.
        Load(); //loads the data
        Debug.Log("Loading saved data");
        DontDestroyOnLoad(gameObject);
    }
    public void SetName(string name)
    {
        PlayerName = name;
    }
    public void SetVolume(float volume)
    {
        VolumeSetting = volume;
    }

    [System.Serializable]
    class PlayerSaveData
    {
        public float TimeScore;
        public string playerName;
        public float volumeSetting;
    }
    public void Save()
    { 
        PlayerSaveData data = new PlayerSaveData(); //new save data
        data.TimeScore = BestTimeLasted; //Grabs the time, player name and volume setting. I could be smart and split timescore out a bit, but saving program time, will come back.
        data.playerName = PlayerName;
        data.volumeSetting = VolumeSetting;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/playersave.json", json);
    }
    public void Load()
    {
        string path = Application.persistentDataPath + "/playersave.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerSaveData data = JsonUtility.FromJson<PlayerSaveData>(json);
            PlayerName = data.playerName;
            VolumeSetting = data.volumeSetting;
            BestTimeLasted = data.TimeScore;
            //Reverse as seen in our tutorial. Now I know I don't need to save/load each time. So this time around I can pull the data outside using get encapsulation and keeping in here too.
        }
    }
}
