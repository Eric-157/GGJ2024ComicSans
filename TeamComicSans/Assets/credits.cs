using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("Platformer Test");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Application.Quit();
        }
    }
}
