using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : Entity
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

    public override void Mutate()
    {
        // Quick and dirty mutation
        if (UnityEngine.Random.value <= 0.5)
        {
            this.transform.position += new Vector3(Random.value - 0.5f, Random.value - 0.5f, 0);
        }
        else
        {
            float newScale = this.transform.localScale.x + Random.value - 0.5f;
            this.transform.localScale.Set(newScale, newScale, 0);
        }

    }
}