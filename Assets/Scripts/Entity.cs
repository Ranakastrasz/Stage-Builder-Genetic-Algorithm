using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// baseclass of all Entity types.

public abstract class Entity : MonoBehaviour
{

    public virtual void Mutate()
    {}

    public virtual void Reload()
    {}
}
