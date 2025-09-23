using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level-1");

    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("CreditsMenu");
    }
}