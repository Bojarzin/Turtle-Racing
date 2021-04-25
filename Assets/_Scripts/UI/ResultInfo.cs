using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultInfo : MonoBehaviour
{
    private static ResultInfo _instance;

    public static ResultInfo Instance { get { return _instance; } }

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

    public float lapOneTime;
    public float lapTwoTime;
    public float lapThreeTime;

    public bool hasSpawned;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        if (hasSpawned == false)
        {
            StartCoroutine(HintTextTimer());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator HintTextTimer()
    {
        yield return new WaitForSeconds(6.0f);

        hasSpawned = true;
    }
}
