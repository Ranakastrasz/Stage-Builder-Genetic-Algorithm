using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// tells which genomes to be overwritten, which to mutate, and sorts them by score and so on.

public class GeneManager : MonoBehaviour
{
    // Loop Through all Genomes to Evaluate.
    // Sort Genomes.
    // Override Low-grade Genomes.
    // Mutate Genomes.
    // Repeat.

    public void Start()
    {
        
    }

    public void TestGenome(Genome iGenome)
    {
        iGenome.Reload();
        iGenome.Enable(true);
        foreach (GameObject child in Stage.Active.transform)
        { 
            //child.
        }

    }

}