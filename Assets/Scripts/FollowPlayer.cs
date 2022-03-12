using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;//creating variable or object to get Transform properties from "Player" object.
    public float offSet = -7.0f;  //offset value initialized as -7.0 so that the camera stays behind and shows the "Player" movement from a perfect angle at all times.


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = transform.position; //assigning and storing the value of xyz position for main camera in the variable cameraPos at each frame
        cameraPos.z = playerTransform.position.z + offSet;//then changing the z axis value for main camera by getting the z axis value for "Player" object and by subtracting it with -7 value at each frame so that camera stays behind the "Player" object at all times and in each frame
        transform.position = cameraPos;  //assigning the new value with updated z axis value to the position of Main camera's object.

    }
}
