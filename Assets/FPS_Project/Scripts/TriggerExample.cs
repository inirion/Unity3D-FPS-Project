using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " has entered");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " has exited");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name + " is in the trigger");
    }
}
