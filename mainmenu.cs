using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoBackToMenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
