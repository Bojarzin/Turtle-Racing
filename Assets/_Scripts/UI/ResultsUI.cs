using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultsUI : MonoBehaviour
{
    public TMP_Text lapTime;

    float lapOneTime;
    float lapTwoTime;
    float lapThreeTime;

    float minutes;
    float seconds;

    // Start is called before the first frame update
    void Start()
    {
        lapOneTime = ResultInfo.Instance.lapOneTime;
        lapTwoTime = ResultInfo.Instance.lapTwoTime;
        lapThreeTime = ResultInfo.Instance.lapThreeTime;

        minutes = Mathf.FloorToInt(lapOneTime / 60);
        seconds = Mathf.FloorToInt(lapOneTime % 60);

        string time = string.Format("{0:0}:{1:00}", minutes, seconds);
        lapTime.text = "Lap One: " + time;

        minutes = Mathf.FloorToInt(lapTwoTime / 60);
        seconds = Mathf.FloorToInt(lapTwoTime % 60);

        time = string.Format("{0:0}:{1:00}", minutes, seconds);
        lapTime.text += "\nLap Two: " + time;

        minutes = Mathf.FloorToInt(lapThreeTime / 60);
        seconds = Mathf.FloorToInt(lapThreeTime % 60);

        time = string.Format("{0:0}:{1:00}", minutes, seconds);
        lapTime.text += "\nLap Three: " + time;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
