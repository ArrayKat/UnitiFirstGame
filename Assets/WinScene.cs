using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    public Button button;
   
    void Start()
    {
        button.onClick.AddListener(ToMainMenu);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void ToMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
   
}
