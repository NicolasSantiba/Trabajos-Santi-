using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public int speed = 0;
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * Time.deltaTime * speed; 
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * Time.deltaTime * speed;
        }


    }
}
