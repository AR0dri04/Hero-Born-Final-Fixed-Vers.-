using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 myStartPosition = new Vector3(82, 15, -49);
    public Vector3 myEndPosition = new Vector3(82, 15, -84);
    public int Speed = 3;
    public bool Forward = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z >= myEndPosition.z)
        {
            Forward = false;
        }
        if (gameObject.transform.position.z <= myStartPosition.z)
        {
            Forward = true;
        }
        if (Forward == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + (Time.deltaTime * Speed));

        }
        if (Forward == false)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - (Time.deltaTime * Speed));
        }
    }
}
