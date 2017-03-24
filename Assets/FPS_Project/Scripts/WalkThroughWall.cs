using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkThroughWall : MonoBehaviour {

    void OnEnable()
    {
        //gameObject.layer = 10; //id od layer form unity or by name
        gameObject.layer = LayerMask.NameToLayer("NotSolid");
    }

    void OnDisable()
    {
        //gameObject.layer = 1;
        gameObject.layer = LayerMask.NameToLayer("Default");
    }
}
