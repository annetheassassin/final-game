using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public static bool GameOver = true;
    
    public GameObject DieUIPanel;

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if (GameOver) 
                {   
                    Resume();
                } else
                {
                    Pause();
                }
    
            }
    }

      public void Resume()
    {
        DieUIPanel.SetActive(false);
        Time.timeScale = 1f;
        GameOver = false;
    }

    void Pause ()
    {
        DieUIPanel.SetActive(true);
        Time.timeScale = 0f;
        GameOver = true;
    }   

    public void Restart()
    {
        Time.timeScale = 1f;
        GameOver = false;
        DieUIPanel.SetActive(false);
        SceneManager.LoadScene("test begin eindpunt route");
        WaveSpawner.nrofEnemies = 0;
        WaveSpawner.countdown = 15f;
        
    }

    public void QuitGame()
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