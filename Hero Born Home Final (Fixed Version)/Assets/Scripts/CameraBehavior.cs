using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    //1
    private Vector3 CamOffset = new Vector3(0f, 2f, -4.1f);
    //2
    private Transform _target;
    // Start is called before the first frame update
    void Start()
    {
        
        //3
        _target = GameObject.Find("Player").transform;
    }
    //4
    // Update is called once per frame
    void LateUpdate()
    {
        //5
        this.transform.position = _target.TransformPoint(CamOffset);
        //6
        this.transform.LookAt(_target);
    }
}
