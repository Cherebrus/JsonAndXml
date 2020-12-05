using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class Json : MonoBehaviour
{
    [SerializeField] PlayerData playerData ;
    
    
    
    string json;
    string jsonPeth = "/Json/Save Game.Json";

    
    private void Start()
    {
        playerData.level = 0;
        CreatFolder();
    }

    private void Update()
    {
        
        SaveJason();
        LoadJason();
    }
    
    public void SaveJason()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        { 
            json = JsonUtility.ToJson(playerData);
            File.WriteAllText(Application.dataPath + jsonPeth,json);
            Debug.Log(json + "save");
            

        }
    }

    public void LoadJason()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            json = File.ReadAllText(Application.dataPath + jsonPeth);
            Load loadFromJason = JsonUtility.FromJson<Load>(json);
            playerData.level = loadFromJason.level;
            playerData.name = loadFromJason.name;
            playerData.inventory = loadFromJason.inventory;
            Debug.Log(json + "load");
        }
    }


    void CreatFolder()
    {
        if (!Directory.Exists(Application.dataPath + "/Json"))
        {
            Directory.CreateDirectory(Application.dataPath + "/Json");
        }
    }
    

    

    

}

