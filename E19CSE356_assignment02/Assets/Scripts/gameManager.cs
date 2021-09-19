using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    private float restartDelay = 5.0f;
    public bool gameHasEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame() {
        gameHasEnded = true;
        Debug.Log("GAME OVER!!! Score: " + FindObjectOfType<score>().scoreCount);
        Invoke("Restart", restartDelay);
    }

    void Restart() {
        SceneManager.LoadScene(0);
    }

    public void DestroyPrefabsInScene(string tagName) {
        GameObject[] prefabs = GameObject.FindGameObjectsWithTag(tagName);
        foreach (GameObject prefab in prefabs) {
            Destroy(prefab);
        }
    }
}
