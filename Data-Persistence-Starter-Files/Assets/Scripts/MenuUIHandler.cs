using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField playerNameInputField;

    // Start is called before the first frame update
    void Start()
    {
        // Load high score on menu start to display it if needed
        if (MainManager.Instance != null)
        {
            // Display high score in the menu (optional)
            // You can access MainManager.Instance.highScorePlayer here
        }
    }

    public void StartMain()
    {
        string playerName = playerNameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        SceneManager.LoadScene(1);
    }
}