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
            //    Debug.Log("Sploosh");
            //    other.gameObject.transform.position = other.GetComponent<PlayerController>().placeToRespawn.position;
            //    other.gameObject.transform.rotation = other.GetComponent<PlayerController>().placeToRespawn.localRotation;

            //    other.GetComponent<PlayerController>().GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<PlayerController>().Respawn();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>())
        {
            Debug.Log("Sploosh");
            //collision.gameObject.transform.position = collision.gameObject.GetComponent<PlayerController>().placeToRespawn.position;
            //collision.gameObject.transform.rotation = collision.gameObject.GetComponent<PlayerController>().placeToRespawn.localRotation;

            //collision.gameObject.GetComponent<PlayerController>().GetComponent<Rigidbody>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<PlayerController>().Respawn();
        }
    }
}