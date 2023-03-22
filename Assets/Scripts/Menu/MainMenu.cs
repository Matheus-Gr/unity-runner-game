using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private void Start()
    {
        bool firstPlay = Convert.ToBoolean(PlayerPrefs.GetInt("FirstPlay", 1));
        if (firstPlay) {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetInt("CoinCount", 4000);
            PlayerPrefs.SetInt("FirstPlay", 0);
            PlayerPrefs.Save();
        }
    }

    public void PlayGame()
    {
        StartCoroutine(FindObjectOfType<GeralSFX>().PlayBtnSFXAndWaitForLoadScene(0,1));
    }

    public void Collection()
    {
        StartCoroutine(FindObjectOfType<GeralSFX>().PlayBtnSFXAndWaitForLoadScene(0, 2));
    }

    public void QuitGame()
    {
        StartCoroutine(PlayBtnSFXAndWaitForQuit(1));
    }

    IEnumerator PlayBtnSFXAndWaitForQuit(int sfxIndex)
    {
        FindObjectOfType<GeralSFX>().PlaySFX(sfxIndex);
        yield return new WaitForSeconds(1.0f);
        #if UNITY_STANDALONE
            Application.Quit();
        #endif
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
