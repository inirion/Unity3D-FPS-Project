using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    private float _fireRate;
    private float _nextFire;
    private RaycastHit _hit;
    [SerializeField]
    private float _range;
    private Transform _myTransform;

	// Use this for initialization
	void Start () {
        _fireRate = 0.2f;
        SetInitialReferences();
    }

    void SetInitialReferences()
    {
        _myTransform = transform;
    }
    // Update is called once per frame
    void Update () {
        CheckForInput();
    }

    void CheckForInput()
    {
        if (Input.GetButton("Fire1") && Time.time>_nextFire)
        {
            Debug.DrawRay(_myTransform.TransformPoint(0,0,1), _myTransform.forward, Color.red, 3.0f);
            if (Physics.Raycast(_myTransform.TransformPoint(0, 0, 1), _myTransform.forward, out _hit, _range))
            {
                if (_hit.transform.CompareTag("Enemy"))
                {
                    Debug.Log("Enemy : " + _hit.transform.name);
                }
                
            }
            _nextFire = Time.time + _fireRate;
            
        }
    }
}
