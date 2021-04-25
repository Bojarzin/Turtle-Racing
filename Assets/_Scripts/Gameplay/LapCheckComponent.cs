using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCheckComponent : MonoBehaviour
{
    public bool playerHasTouched;

    // Start is called before the first frame update
    void Start()
    {
        playerHasTouched = false;
        GameManager.Instance.lapChecks.Add(this);

        this.GetComponentInChildren<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            if (playerHasTouched == false)
            {
                GameManager.Instance.lapCheck += 1;
                playerHasTouched = true;
            }
        }
    }
}
