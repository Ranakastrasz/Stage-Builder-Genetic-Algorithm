using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour
{
    [SerializeField]
    private float Magnitude = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.name + " : " + gameObject.name + " : " + Time.time);
    
        //Debug.Log("OnTriggerEnter2D");
        GameObject collider = collision.gameObject;
        Particle particle = collider.GetComponent<Particle>();
        if (particle != null)
        {
            // Actually is a particle
            Vector2 VectorBetween = collision.gameObject.transform.position - gameObject.transform.position;
    
            Vector2 acceleration = VectorBetween * Magnitude;
    
            collider.GetComponent<Rigidbody2D>().AddForce(acceleration,ForceMode2D.Force);
        }
    }
}