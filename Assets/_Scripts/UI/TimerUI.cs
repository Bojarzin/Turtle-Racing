using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerUI : MonoBehaviour
{
    public TMP_Text time;

    public TMP_Text lapsText;
    public TMP_Text hint;
    float hintAlpha = 1.0f;

    public Image blackImage;
    float alpha = 0.0f;
    Vector4 newColour = new Vector4(0, 0, 0, 0);

    float minutes;
    float seconds;

    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
        if (ResultInfo.Instance.hasSpawned == true)
        {
            hint.text = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }

    void UpdateTime()
    {
        time.text = GameManager.Instance.TimeToDisplay();
        FadeBlack();

        if (ResultInfo.Instance.hasSpawned == true)
        {
            if (hintAlpha > 0)
            {
                hintAlpha -= Time.deltaTime;
                hint.color = new Vector4(0.4310253f, 0.4848309f, 0.5471698f, hintAlpha);
            }
        }
        else
        {

        }
    }

    public void UpdateText()
    {
        if (GameManager.Instance.lapCount == 0)
        {
            lapsText.text = "";
        }
        if (GameManager.Instance.lapCount == 1)
        {
            minutes = Mathf.FloorToInt(GameManager.Instance.lapOneTime / 60);
            seconds = Mathf.FloorToInt(GameManager.Instance.lapOneTime % 60);

            string time = string.Format("{0:0}:{1:00}", minutes, seconds);
            lapsText.text = "Lap One: " + time;
        }
        if (GameManager.Instance.lapCount == 2)
        {
            minutes = Mathf.FloorToInt(GameManager.Instance.lapTwoTime / 60);
            seconds = Mathf.FloorToInt(GameManager.Instance.lapTwoTime % 60);

            string time = string.Format("{0:0}:{1:00}", minutes, seconds);
            lapsText.text += "\nLap Two: " + time;
        }
    }

    public void FadeBlack()
    {
        if (GameManager.Instance.lapCount == 3)
        {
            if (alpha < 1.0f)
            {
                alpha += 0.25f * Time.deltaTime;
            }
            newColour = new Vector4(0, 0, 0, alpha);
            blackImage.color = newColour;
        }
    }

    public void Unpause()
    {
        Time.timeScale = 1.0f;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
