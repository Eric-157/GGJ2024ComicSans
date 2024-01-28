using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DuckGoal : MonoBehaviour
{
    public static bool duckwin = false;
    void OnTriggerEnter2D()
    {
        duckwin = true;
        SceneManager.LoadScene("Platformer Test");
    }
}
