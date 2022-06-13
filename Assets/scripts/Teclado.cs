using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teclado : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Izquierda");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Derecha");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Arriba");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Abajo");
        }

    }
       



    }
