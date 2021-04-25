using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckpointComponent : MonoBehaviour
{
    public TMP_Text signText;
    public GameObject respawn;

    public bool finalCheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.checkpointSignsText.Add(this.signText);

        GameManager.Instance.UpdateSignText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            if (finalCheckpoint)
            {
                if (GameManager.Instance.lapCheck >= 3)
                {
                    GameManager.Instance.lapCount += 1;
                    GameManager.Instance.UpdateSignText();
                    GameManager.Instance.ResetTimer();
                    GameManager.Instance.UI.UpdateText();

                    for (int i = 0; i < GameManager.Instance.lapChecks.Count; i++)
                    {
                        GameManager.Instance.lapChecks[i].playerHasTouched = false;
                        GameManager.Instance.lapCheck = 0;
                    }
                }
            }
            other.GetComponent<PlayerController>().placeToRespawn = respawn.transform;
        }
    }
}
