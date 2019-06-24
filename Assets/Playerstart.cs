using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerstart : MonoBehaviour
{

    void
     Start()
    {
        SceneManager.LoadScene("Playerscene", LoadSceneMode.Additive);


    }
}