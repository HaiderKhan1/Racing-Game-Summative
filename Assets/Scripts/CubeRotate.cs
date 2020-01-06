using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
   

    // Update is called once per frame
    //roatate the cube along the y axis 
    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }
}
