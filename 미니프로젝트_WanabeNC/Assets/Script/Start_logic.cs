using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_logic : MonoBehaviour {

    public void Click_start()
    {
        SceneManager.LoadScene("Main");
    }

    public void Click_exit()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
                        Application.OpenURL("http://google.com");
        #else
                        Application.Quit();
        #endif
    }
}
