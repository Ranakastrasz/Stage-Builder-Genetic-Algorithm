using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Contains entities, which are static and not manipulated by genomes.
// Doesn't actually do anything on it's own.

public class Stage : MonoBehaviour
{
    public static Stage Active;

    public void Start()
    {
        Active = this;
    }
}
