using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class survive : MonoBehaviour
{
    public float timeRemaining;
    public bool timerIsRunning = false;
    public bool winCondition = false;
    private void Start()
    {
        timerIsRunning = true;
        timeRemaining = Random.Range(30, 50);
        GameObject.Find("ScoreSaver").GetComponent<dontDestroy>();
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
        if (GameObject.Find("ScoreSaver").GetComponent<dontDestroy>().hellWin == true)
        {
        }
        else
        {
            GameObject.Find("ScoreSaver").GetComponent<dontDestroy>().hellWin = true;
        }

        SceneManager.LoadScene("Platformer Test");
    }

   
}
