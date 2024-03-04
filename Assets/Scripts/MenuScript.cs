using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public TextMeshProUGUI _TextMeshPro;
    public TMP_InputField  PlayerNameInputField;
    private MenuScript Instance;
   
    
    public string playerName;
    public int highScore;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        playerName = PlayerPrefs.GetString("PlayerName");
        highScore = PlayerPrefs.GetInt("HighScore");
        PlayerNameInputField.text = playerName;
        _TextMeshPro.text = "Best Score: " + highScore + " Name : " + playerName;
    }


    public void StartGame()
    {
        playerName = PlayerNameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        Debug.Log(playerName);
        SceneManager.LoadScene(1);
    }
    
}
