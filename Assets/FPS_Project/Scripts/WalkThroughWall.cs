using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkThroughWall : MonoBehaviour {
    private Color _myColor;
    void Start()
    {
        _myColor = new Color(0.5f, 1, 0.5f, 1);
    }
    void OnEnable()
    {
        //gameObject.layer = 10; //id od layer form unity or by name
    }

    void OnDisable()
    {
        //gameObject.layer = 1;
    }

    public void SetLairToNotSolid()
    {
        gameObject.layer = LayerMask.NameToLayer("NotSolid");
        GetComponent<Renderer>().material.SetColor("_Color", _myColor);
    }

    public void SetLairToDefault()
    {
        gameObject.layer = LayerMask.NameToLayer("Default");
        GetComponent<Renderer>().material.color = Color.white;
    }
}
