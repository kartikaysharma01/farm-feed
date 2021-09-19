using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    public int scoreCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = scoreCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        // update score and assign it to text UI
        scoreCount = scoreCount + 1;
        Debug.Log("Score: " + scoreCount);
        scoreText.text = scoreCount.ToString();
    }

}
