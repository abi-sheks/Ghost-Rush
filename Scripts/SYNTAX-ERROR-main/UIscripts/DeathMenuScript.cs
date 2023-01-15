using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class DeathMenuScript : MonoBehaviour
{


    public void QuitGame(){
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void GoToMainMenu(){
        SceneManager.LoadScene(0);
    }
}
