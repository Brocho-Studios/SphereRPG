using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    public void Play () {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("");
    }

    public void Discord () {    
        Application.OpenURL("https://discord.gg/Jm5XAbF");
    }

    public void SetFullscreen (bool isFullscreen) { 
        Screen.fullScreen = isFullscreen;
}

    public void Options () {    
        SceneManager.LoadScene(0);
    }
}