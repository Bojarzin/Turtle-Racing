using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;

    public static AudioManager Instance { get { return _instance; } }

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

    public AudioClip[] audioClips;
    public int index;
    public bool mainMenu = false;
    bool stopSong = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        StopSong();

        if (!GetComponent<AudioSource>().isPlaying)
        {
            Change();
        }
    }

    void StopSong()
    {
        if (stopSong)
        {
            if (GetComponent<AudioSource>().volume > 0)
            {
                GetComponent<AudioSource>().volume -= 0.0005f;

                if (GetComponent<AudioSource>().volume <= 0)
                {
                    GetComponent<AudioSource>().Stop();
                    GetComponent<AudioSource>().volume = 0.1f;
                    stopSong = false;
                    StartNewSong();
                }
            }
        }
    }

    public void Change()
    {
        stopSong = true;
    }

    void StartNewSong()
    {
        if (mainMenu)
        {
            GetComponent<AudioSource>().clip = audioClips[0];
        }
        else
        {
            if (GetComponent<AudioSource>().clip == audioClips[0])
            {
                int rand = Random.Range(1, 3);
                Debug.Log("Rand: " + rand);
                GetComponent<AudioSource>().clip = audioClips[rand];
            }
            else if (GetComponent<AudioSource>().clip == audioClips[1])
            {
                GetComponent<AudioSource>().clip = audioClips[2];
            }
            else if ((GetComponent<AudioSource>().clip == audioClips[2]))
            {
                GetComponent<AudioSource>().clip = audioClips[1];
            }
        }

        if (GetComponent<AudioSource>().clip == audioClips[2])
        {
            GetComponent<AudioSource>().volume = 0.03f;
        }
        else
        {
            GetComponent<AudioSource>().volume = 0.08f;
        }

        GetComponent<AudioSource>().Play();
    }
}
