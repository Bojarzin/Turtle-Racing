using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public Canvas mainMenuCanvas;
    public Canvas instructionCanvas;
    public Canvas creditsCanvas;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.mainMenu = true;
        AudioManager.Instance.Change();
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenMainMenu()
    {
        mainMenuCanvas.enabled = true;
        instructionCanvas.enabled = false;
        creditsCanvas.enabled = false;
    }

    public void OpenInstructions()
    {
        instructionCanvas.enabled = true;
        creditsCanvas.enabled = false;
        mainMenuCanvas.enabled = false;
    }

    public void OpenCredits()
    {
        mainMenuCanvas.enabled = false;
        instructionCanvas.enabled = false;
        creditsCanvas.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
