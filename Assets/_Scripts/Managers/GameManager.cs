using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public int lapCount = 0;

    public float timer = 0.0f;
    float minutes;
    float seconds;

    public float lapOneTime;
    public float lapTwoTime;
    public float lapThreeTime;

    public List<TMP_Text> checkpointSignsText;

    public TimerUI UI;

    float fadeTime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.mainMenu = false;
        AudioManager.Instance.Change();
        UpdateSignText();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    public string TimeToDisplay()
    {
        minutes = Mathf.FloorToInt(timer / 60);
        seconds = Mathf.FloorToInt(timer % 60);

        string time = string.Format("{0:0}:{1:00}", minutes, seconds);
        return time;
    }

    void Timer()
    {
        if (lapCount < 3)
        {
            timer += Time.deltaTime;
        }
        else
        {
            fadeTime -= Time.deltaTime;
            if (fadeTime <= 0.0f)
            {
                SceneManager.LoadScene("WinScene");
            }
        }
    }

    public void UpdateSignText()
    {
        for (int i = 0; i < checkpointSignsText.Count; i++)
        {
            checkpointSignsText[i].text = lapCount.ToString() + "/3 laps completed";
        }
    }

    public void ResetTimer()
    {
        if (lapCount == 1)
        {
            lapOneTime = timer;
            ResultInfo.Instance.lapOneTime = timer;
        }
        else if (lapCount == 2)
        {
            lapTwoTime = timer;
            ResultInfo.Instance.lapTwoTime = timer;
        }
        else if (lapCount == 3)
        {
            lapThreeTime = timer;
            ResultInfo.Instance.lapThreeTime = timer;
        }
        timer = 0.0f;
    }
}
