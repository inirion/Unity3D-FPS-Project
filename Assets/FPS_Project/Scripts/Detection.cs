using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour {
    private RaycastHit _hit;
    [SerializeField]
    private LayerMask _detectionLayer;
    private float _checkRate;
    private float _nextCheck;
    private Transform _myTransfom;
    private float _range;
	// Use this for initialization
	void Start () {
        _checkRate = 0.5f;
        _nextCheck = 0.0f;
        SetInitialReferences();
        _range = 5;
    }

    void SetInitialReferences()
    {
        _myTransfom = transform;
        _detectionLayer = 1 << 9;//setting layer in code layer is 32bit so if u wonna select layer 9 (for me its Items) u do bit operation 1<<9 with gives u
                                //00000000 00000000 00000001 00000000
                                //if what you wanna do it for more layers eg 3 and 9  -- >  1<<9 | 1<<3
                                //I'm selecting lair to scan only for objects located in this layer(it helps with performance)
    }
	
	// Update is called once per frame
	void Update () {
        DetectItems();

    }

    void DetectItems()
    {
        if(Time.time > _nextCheck)//detect if item is in range and belongs to selected layer every _checkRate secound in my case 0.5 sec
        {

            if(Physics.Raycast(_myTransfom.position, _myTransfom.forward,out _hit, _range, _detectionLayer))
            {
                Debug.Log(_hit.transform.name + " Is an item");
            }

            _nextCheck = Time.time + _checkRate;
        }
    }
}
