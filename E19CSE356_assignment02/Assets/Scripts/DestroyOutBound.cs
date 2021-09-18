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
            // user could not feed the animal -- destroy all food/animal object and end game
            FindObjectOfType<gameManager>().DestroyPrefabsInScene("food");
            FindObjectOfType<gameManager>().DestroyPrefabsInScene("animal");
            FindObjectOfType<gameManager>().EndGame(); 
        } else if(transform.position.x < foodBound) {
            Destroy(gameObject);
        }
    }
}
