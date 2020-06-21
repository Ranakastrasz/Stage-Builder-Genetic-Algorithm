using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The source of Particles.Generates a large number and sends them in all directions.


public class WhiteHole : MonoBehaviour
{
    public GameObject _particlePrototype; // Particle GameObject.
    
    [SerializeField]
    private float _startingSpeed = 5f;

    [SerializeField]
    private int _particleCount = 64;


    // Start is called before the first frame update
    void Start()
    {
        //Spawn(); // Temp, will be from gameManager later.
        //InvokeRepeating("Spawn",2f,2f);
    }
    
    public void Spawn()
    {
        for (int x = 0; x < _particleCount; x++)
        {
            float angle = (Mathf.PI * 2 / _particleCount) * x;
            Vector2 force = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
            force *= _startingSpeed;
            GameObject newObj = GameObject.Instantiate(_particlePrototype, transform.position, Quaternion.identity);
            newObj.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);
            //newObj.transform.parent = GameBoard._instance._particleContainer.transform;
            //newObj.GetComponent<Particle>()._stageBuilder = _stageBuilder;
        }
    }
}