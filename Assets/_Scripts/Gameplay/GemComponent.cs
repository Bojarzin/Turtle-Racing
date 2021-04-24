using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemComponent : MonoBehaviour
{
    public Powerups power;

    float timer = 10.0f;
    bool startTimer;


    // Start is called before the first frame update
    void Start()
    {
        power = new Powerups();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        if (startTimer)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                startTimer = false;
                timer = 10.0f;
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            transform.localScale = new Vector3(0, 0, 0);
            if (GetComponent<AudioSource>().isPlaying == false)
            {
                GetComponent<AudioSource>().Play();
            }
            startTimer = true;

            if (other.GetComponent<PlayerController>().currentPowerup.Count == 0)
            {
                power.CyclePower();
 
                other.GetComponent<PlayerController>().currentPowerup.Add(power);
                other.GetComponent<PlayerController>().cycleSprites = true;
               
                Debug.Log("Power: " + power.powerType);
                Debug.Log("Cycle: " + power.cycle);
            }
            else
            {
                if (other.GetComponent<PlayerController>().CheckForJumps())
                {
                    Debug.Log(other.GetComponent<PlayerController>().CheckForJumps().ToString());
                    if (power.powerType != PowerType.JUMP)
                    {
                        Debug.Log(power.powerType.ToString());
                        other.GetComponent<PlayerController>().currentPowerup.Add(power);
                        other.GetComponent<PlayerController>().cycleSprites = true;
                    }
                }
            }
        }
    }
}
