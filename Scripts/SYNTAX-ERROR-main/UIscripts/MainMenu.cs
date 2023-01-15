using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private GameObject settingMenu;
    private GameObject pauseMenu;
    private GameObject logic;
    private GameObject deathmenu;
    TimeTracker timeTracker;


    void Start(){
        settingMenu = GameObject.Find("SettingMenu");
        timeTracker = GameObject.Find("Logic").GetComponent<TimeTracker>();
        pauseMenu = GameObject.Find("PauseMenu");
//        deathmenu = GameObject.Find("DeathMenu");

    }
    public void StartGame(){
        gameObject.SetActive(false);
        pauseMenu.SetActive(false);
        settingMenu.SetActive(false);
//        deathmenu.SetActive(false);
        timeTracker.inGame = true;
 
    } 
    public void QuitGame(){
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void Settings(){
        gameObject.SetActive(false);
        settingMenu.SetActive(true);

    }
}
