using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public static bool GameOver = true;

    public GameObject DieUIPanel;
    public static GameObject DieUIPanel_;

    private void Start()
    {
        DieUIPanel_ = DieUIPanel;
    }

    // Update is called once per frame
    void FixedUpdate()
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

    public static void Resume()
    {
        DieUIPanel_.SetActive(false);
        Time.timeScale = 1f;
        GameOver = false;
    }

    public static void Pause ()
    {
        DieUIPanel_.SetActive(true);
        Time.timeScale = 0f;
        GameOver = true;
    }   

    public static void Restart()
    {
        Time.timeScale = 1f;
        GameOver = false;
        DieUIPanel_.SetActive(false);
        SceneManager.LoadScene("test begin eindpunt route");
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