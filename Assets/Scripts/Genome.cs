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

    public void Reload()
    {
        _fitness = 0;
        foreach (GameObject child in transform)
        {
            Entity entity = child.GetComponent<Entity>();
            if (entity != null)
            {
                entity.Reload();
            }
        }
    }
    public int GetFitness()
    {
        return _fitness;
    }

    public Genome Clone()
    {
        Genome oGenome = Instantiate(this, this.transform.parent);
        return oGenome;
    }

    public void Mutate(float iMutationFactor)
    {
        // May also add ability to create/destroy as well. Later. Maybe
        foreach (GameObject child in transform)
        {
            if (UnityEngine.Random.value < iMutationFactor)
            {
                Entity entity = child.GetComponent<Entity>();
                if (entity != null)
                {
                    entity.Mutate(); // Might include parameters later.
                }
            }
        }
    }
}