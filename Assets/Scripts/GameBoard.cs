using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Contains the Stage, and all Genomes, as well as the graphical background.
// Also contains active particles.


public class GameBoard : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Border Patrol.
        // No Particles allowed to leave.
        Particle particle = collision.gameObject.GetComponent<Particle>();
        if (particle != null)
        {
            particle.Die();
        }
    }

}
