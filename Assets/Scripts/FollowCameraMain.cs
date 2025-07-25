using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 // The target to follow

public class FollowCameraMain : MonoBehaviour
{
    public Transform target;
    float xCamera;
    float yCamera;
    float zCamera;


    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            return;
        }
        xCamera = target.position.x;
        yCamera = target.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position;
        transform.position = new Vector3(targetPosition.x, targetPosition.y, target.position.z - 10);
    }
}
