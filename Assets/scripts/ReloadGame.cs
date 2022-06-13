using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour
{

    // Update is called once per frame
    public void NewScene()
    {
        SceneManager.LoadScene (0);
    }
}
