using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splat : MonoBehaviour
{
    public Sprite chickenSplat;
    public bool spriteChanged;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (transform.position.y >-1)
            {
                transform.Translate(0f, -4f, 0f);
            }
            this.gameObject.GetComponent<SpriteRenderer>().sprite = chickenSplat;
            spriteChanged = true;
            Invoke("LoadScene",1);
        }
    }
    private void LoadScene()
    {
        SceneManager.LoadScene("Platformer Test");
    }
}
