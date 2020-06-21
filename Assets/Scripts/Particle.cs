using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Physics rigidbody which interacts with entities, and has a limited lifespan. Destroyed if it leaves the bounds, or touches a blackhole.


public class Particle : MonoBehaviour
{
    public Transform _transform
    {
        get { return _transform; }   // get method
        private set { _transform = value; }  // set method
    }

    private void Start()
    {
        _transform = this.transform;
        Invoke("Die", 30f);
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }
}
