using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The goal of particles. Genome gains score when a particle touches it, based on how much life it has left.


public class BlackHole : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name + " : " + gameObject.name + " : " + Time.time);

        //Debug.Log("OnTriggerEnter2D");
        GameObject collider = other.gameObject;
        Particle particle = collider.GetComponent<Particle>();
        if (particle != null)
        {
                //Actually is a particle
                Destroy(collider);
        }
    }
}