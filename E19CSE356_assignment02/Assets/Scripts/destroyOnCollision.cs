using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // destroy both food and animal on collision, also update the score
    void OnTriggerEnter(Collider other) {
        // call update score
        FindObjectOfType<score>().UpdateScore();
        // destroy the food and animal
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
