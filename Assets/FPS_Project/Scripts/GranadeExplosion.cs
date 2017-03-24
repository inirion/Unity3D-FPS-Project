using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeExplosion : MonoBehaviour {
    private Collider[] _hitColliders;
    [SerializeField]
    private float _blastRadious;
    [SerializeField]
    private float _explosionPower;
    [SerializeField]
    private LayerMask _explosionLayers;

    void Start()
    {
        //SetInitialReferences(); // if need to be set via script to all but player else initialize via unity
    }
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.contacts[0].point.ToString());
        ExplosionWork(collision.contacts[0].point);
       
        Destroy(gameObject);
    }

    void ExplosionWork(Vector3 ExplosionPoint)
    {
        _hitColliders = Physics.OverlapSphere(ExplosionPoint, _blastRadious, _explosionLayers);

        foreach (Collider hitCollider in _hitColliders)
        {
            if(hitCollider.GetComponent<Rigidbody>() != null)
            {
                hitCollider.GetComponent<Rigidbody>().isKinematic = false;
                hitCollider.GetComponent<Rigidbody>().AddExplosionForce(_explosionPower, ExplosionPoint, _blastRadious,1,ForceMode.Impulse);
            }
            //Debug.Log(hitCollider.gameObject.name);
        }
    }

    void SetInitialReferences()
    {
        _explosionLayers = 1 | ~(1<<11);
    }
}
