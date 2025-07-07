using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadSceneAsync("Game Scene");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}