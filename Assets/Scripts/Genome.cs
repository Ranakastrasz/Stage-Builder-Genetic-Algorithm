using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Contains entities, and knows how to tell them to mutate when the Genemanager says so.
// Knows how to replace all of it's everything with a copy of another Genome.
// Tracks it's own fitness score.

public class Genome : MonoBehaviour
{
    int _fitness = 0;
    
    public void Enable(bool iFlag)
    {
        gameObject.SetActive(iFlag);

    }

    public void AddFitness(int iScore)
    {
        _fitness += iScore;
    }

    public void ResetFitness()
    {
        _fitness = 0;
    }

    public int GetFitness()
    {
        return _fitness;
    }

    // Mutation
}