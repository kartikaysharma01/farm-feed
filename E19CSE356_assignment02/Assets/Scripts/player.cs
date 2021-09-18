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

        // Launch a projectie from the user on clicking space
        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector3 foodPos = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
            Instantiate(foodPrefab, foodPos, foodPrefab.transform.rotation);
        }
    }
}
