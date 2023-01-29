using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public static bool GameWON = true;
    
    public GameObject WINMenu_;
    public static GameObject WINMenu;

    private void Start()
    {
        WINMenu = WINMenu_;
    }

    // Update is called once per frame
    void Update()
    {
            // Typ hier in If statement de code als de game gewonnen is
            if(Input.GetKeyDown(KeyCode.Tab))
            {
                if (GameWON) 
                {   
                    Resume();
                } else
                {
                    Pause();
                }
    
            }
    }

      public static void Resume()
    {
        WINMenu.SetActive(false);
        Time.timeScale = 1f;
        GameWON = false;
    }

    public static void Pause ()
    {
        WINMenu.SetActive(true);
        Time.timeScale = 0f;
        GameWON = true;
    }   

    public static void Restart()
    {
        Time.timeScale = 1f;
        GameWON = false;
        WINMenu.SetActive(false);
        SceneManager.LoadScene("test begin eindpunt route"); // Typ hier de scene Test Begin
        WaveSpawner.nrofEnemies = 0;
        WaveSpawner.countdown = 15f;
        
    }

    public static void QuitGame()
    {
        Debug.Log ("Quitting game....");
        #if UNITY_STANDALONE
        Application.Quit();
    #endif
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    }
}
