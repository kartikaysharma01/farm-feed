using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBound : MonoBehaviour
{
    private float animalBound = 25;
    private float foodBound = -25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy Animals and food if out of bound
        if (transform.position.x > animalBound) {
            Destroy(gameObject);
        } else if(transform.position.x < foodBound) {
            Destroy(gameObject);
        }
    }
}
