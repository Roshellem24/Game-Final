using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject mainMenu;
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowSettings()
    {
        if(settingsMenu.activeInHierarchy)
        {
            Debug.Log("I am not active");
        }
        else
        {
            mainMenu.SetActive(false);
            settingsMenu.SetActive(true);
            Debug.Log("I am active");
        }
    }

    public void BackToMenu()
    {
        if(settingsMenu.activeInHierarchy)
        {
            settingsMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
        else
        {
           
            Debug.Log("I am active");
        }
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}
