using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGranade : MonoBehaviour {
    [SerializeField]
    private GameObject _granadePrefab;
    private Transform _myTransform;
    [SerializeField]
    private float _force;
    private float _fireRate;
    private float _nextFire;
 

	// Use this for initialization
	void Start() {
        _fireRate = 0.5f;
        SetInitialReferences();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            SpawnGranade();
        }
	}

    void SpawnGranade()
    {
        if (Time.time > _nextFire)
        {
            GameObject granade = (GameObject)Instantiate(_granadePrefab, _myTransform.TransformPoint(0, 0, 0.5f), _myTransform.rotation);
            granade.GetComponent<Rigidbody>().AddForce(_myTransform.forward * _force, ForceMode.Impulse);
            Destroy(granade, 5.0f);
            _nextFire = Time.time + _fireRate;
        }
    }

    void SetInitialReferences()
    {
        _myTransform = transform;
    }
}
