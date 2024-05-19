using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    //references the build index in unit through a variable
    int buildindex;

    // Start is called before the first frame update
    void Start()
    {
        buildindex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Build Index: " + buildindex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider myCollision)
    {
        //Allows the game to automatically load the next scene once the required conditions are met.
        SceneManager.LoadScene(buildindex + 1);
        
    }
}
