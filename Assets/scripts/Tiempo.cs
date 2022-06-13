using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{

    public float tiempo = 0;

    void Update()
    {
        tiempo += Time.deltaTime;
       
        if(tiempo > 10)
        {
            Debug.Log("ya son más de 10");
            tiempo = 0; 
         

        }

        
    }
}
