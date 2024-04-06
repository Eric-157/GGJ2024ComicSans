using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DuckGoal : MonoBehaviour
{
    public bool winCondition = false;
    void OnTriggerEnter2D()
    {
        winCondition = true;
        Invoke("LoadScene",1);
    }
    private void LoadScene()
    {
        SceneManager.LoadScene("Platformer Test");
    }
}