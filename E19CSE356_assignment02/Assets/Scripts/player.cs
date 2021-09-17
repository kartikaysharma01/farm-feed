using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 15.0f;
    public GameObject foodPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // do not let player outside game space
        if (transform.position.z < -10) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        } else if (transform.position.z > 30) {
            transform.position = new Vector3(transform.position.x, transform.position.y, 30);
        }

        // read keyboard movements for player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);


        if (Input.GetKeyDown(KeyCode.Space)) {
            // Launch a projectie from the user 
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }
    }
}
