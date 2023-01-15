using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    private GameObject logic;
//    private GameObject deathMenu;

    void Start(){
        logic = GameObject.Find("Logic");
        settingsMenu = GameObject.Find("SettingMenu");
        mainMenu = GameObject.Find("MainMenu");
//        deathMenu = GameObject.Find("DeathMenu");
        
    }

    public void Resume(){
        gameObject.SetActive(false);
        logic.GetComponent<TimeTracker>().inGame = true;
    }
    public void GoToMainMenu(){
        gameObject.SetActive(false);
        mainMenu.SetActive(true);
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }
    public void QuitGame(){
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void Settings(){
        gameObject.SetActive(false);
        settingsMenu.SetActive(true);
    }
}
