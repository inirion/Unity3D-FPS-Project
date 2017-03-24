using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour {
    private WalkThroughWall _walkThroughWallScript;
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name + " has entered");
        SetInitialReferences();
        _walkThroughWallScript.SetLairToNotSolid();
    }

    void OnTriggerExit(Collider other)
    {
        //Debug.Log(other.name + " has exited");
        _walkThroughWallScript.SetLairToDefault();
    }

    //void ontriggerstay(collider other)
    //{
    //    debug.log(other.name + " is in the trigger");
    //}

    void SetInitialReferences()
    {
        if(GameObject.Find("Wall") != null)
        {
            _walkThroughWallScript = GameObject.Find("Wall").GetComponent<WalkThroughWall>();
        }
        else
        {
            Debug.LogError("Object named Wall not found !");
        }
        
    }
}
