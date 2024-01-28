using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            SceneManager.LoadScene("credits");
        }
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
