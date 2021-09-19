using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = FindObjectOfType<gameManager>().score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        // get score refernce from gamemanger, update it and assign it to text UI
        int s = FindObjectOfType<gameManager>().score;
        s = s +1;
        Debug.Log("Score: " + s);
        scoreText.text = s.ToString();
        FindObjectOfType<gameManager>().score = s;
    }

}
