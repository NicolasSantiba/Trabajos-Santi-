using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shutdown : MonoBehaviour
{
    // Start is called before the first frame update
    public void KillGame()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

}
