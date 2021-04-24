using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            Debug.Log("Sploosh");
            other.gameObject.transform.position = other.GetComponent<PlayerController>().placeToRespawn.position;
            other.gameObject.transform.rotation = other.GetComponent<PlayerController>().placeToRespawn.localRotation;

            other.GetComponent<PlayerController>().GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}