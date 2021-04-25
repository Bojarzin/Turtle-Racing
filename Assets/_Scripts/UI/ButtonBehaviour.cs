using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ButtonBehaviour : MonoBehaviour
{
    public Canvas mainMenuCanvas;
    public Canvas instructionCanvas;
    public Canvas creditsCanvas;
    public TMP_Text controlsText;
    public Button keyboardButton;
    public Button controllerButton;

    int controlScheme = 0;

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

    public void ChangeToKeyboardControls()
    {
        keyboardButton.enabled = false;
        //keyboardButton.targetGraphic.color = new Vector4(1, 1, 1, 0.4f);

        controllerButton.enabled = true;
        //controllerButton.targetGraphic.color = new Vector4(1, 1, 1, 0.4f);

        controlScheme = 0;
        ChangeControlSchemeText();
    }

    public void ChangeToControllerControls()
    {
        keyboardButton.enabled = true;
        //keyboardButton.targetGraphic.color = new Vector4(1f, 1f, 1, 1f);

        controllerButton.enabled = false;
        //controllerButton.targetGraphic.color = new Vector4(1, 1, 1, 1f);

        controlScheme = 1;
        ChangeControlSchemeText();
    }

    void ChangeControlSchemeText()
    {
        switch (controlScheme)
        {
            case 0:
                controlsText.text = "Keyboard:\nForward/Backward: W/S\nSteer: A/D\nHandbrake: Left Shift\nJump: Space\nRespawn: E\nPause: ESC";
                break;
            case 1:
                controlsText.text = "Gamepad (PS4 Ex.):\nForward/Backward: R2/L2\nSteer: L\nHandbrake: R1\nJump: X\nRespawn: Triangle\nPause: Start";
                break;
        }
    }
}
