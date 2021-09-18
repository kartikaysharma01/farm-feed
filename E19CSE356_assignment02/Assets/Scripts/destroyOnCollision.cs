using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // destroy both food and animal on collision
    void OnTriggerEnter(Collider other) {
        int s = FindObjectOfType<gameManager>().score;
        s = s +1;
        Debug.Log("Score: " + s);
        FindObjectOfType<gameManager>().score = s;
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
