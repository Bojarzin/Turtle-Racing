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
                GameManager.Instance.lapCount += 1;
                GameManager.Instance.UpdateSignText();
                GameManager.Instance.ResetTimer();
                GameManager.Instance.UI.UpdateText();
            }
            other.GetComponent<PlayerController>().placeToRespawn = respawn.transform;
        }
    }
}
