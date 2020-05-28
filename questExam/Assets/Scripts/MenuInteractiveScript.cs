using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuInteractiveScript : MonoBehaviour
{

    public Button BTNQuit;
    public Button BTNHomeMenu;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToHome()
    {
        SceneManager.LoadScene(0);
    }
}
