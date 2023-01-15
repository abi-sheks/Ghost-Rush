using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScripts : MonoBehaviour
{
    [SerializeField]
    private bool sfx;
    [SerializeField]
    private bool music;
    private Text sfxText;
    private Text musicText;
    private string sToggle;

    private string mToggle;
    public GameObject mainMenu;
    private GameObject logic;
    private GameObject pauseMenu;


    void Start(){
        mainMenu = GameObject.Find("MainMenu");
        sfxText = GameObject.Find("SfxText").GetComponent<Text>();
        musicText = GameObject.Find("MusicText").GetComponent<Text>();
        logic = GameObject.Find("Logic");
        pauseMenu = GameObject.Find("PauseMenu");
        ToggleMusic();
        ToggleSFX();

    }
    public void ToggleSFX(){
        sfx =!sfx;
        if (sfx){
            sToggle= "ON";
        } else {
            sToggle= "OFF";
        }
        sfxText.text = "SFX: "+ sToggle;
    }
    
    public void ToggleMusic(){
        music =! music;
        if (music){
            mToggle= "ON";
        } else {
            mToggle= "OFF";
        }
        musicText.text = "MUSIC: "+mToggle;
    }
    public void GoBack(){
        gameObject.SetActive(false);
        if (logic.GetComponent<TimeTracker>().timeElapsed > 0.1){
            pauseMenu.SetActive(true);
        }else{
            mainMenu.SetActive(true);
        }
    }
}
