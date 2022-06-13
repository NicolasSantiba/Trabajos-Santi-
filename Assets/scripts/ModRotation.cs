using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModRotation : MonoBehaviour
{
    public float rX; 
    public float rY; 
    public float rZ; 

    void Update()
    {

        transform.Rotate(rX, rY, rZ);


    }
}
