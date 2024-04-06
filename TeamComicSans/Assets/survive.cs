using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class survive : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public bool winCondition = false;
    private void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning=false;
                winCondition = true;
                Invoke("LoadScene", 1);
            }
        }
    }
    private void LoadScene()
    {
        SceneManager.LoadScene("Platformer Test");
    }
}
