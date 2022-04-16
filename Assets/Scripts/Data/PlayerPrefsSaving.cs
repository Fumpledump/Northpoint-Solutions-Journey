using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSaving : MonoBehaviour
{
    private PlayerData playerData;

    // Start is called before the first frame update
    void Start()
    {
        CreatePlayerData();
    }

    private void CreatePlayerData()
    {
        playerData = new PlayerData("test", 4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("Issue", playerData.issue);
        PlayerPrefs.SetInt("Health", playerData.health);
        PlayerPrefs.SetInt("Score", playerData.score);
    }

    public void LoadData()
    {
        playerData = new PlayerData(PlayerPrefs.GetString("Issue"), 
            PlayerPrefs.GetInt("Health"), PlayerPrefs.GetInt("Score"));

        Debug.Log(playerData.ToString());
    }
}
