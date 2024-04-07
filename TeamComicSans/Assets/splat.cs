using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splat : MonoBehaviour
{
    public Sprite chickenSplat;
    public bool winCondition;
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
            winCondition = true;
            Invoke("LoadScene",1);
        }
    }
    private void LoadScene()
    {
        if (GameObject.Find("ScoreSaver").GetComponent<dontDestroy>().bridgeWin == true)
        {
        }
        else
        {
            GameObject.Find("ScoreSaver").GetComponent<dontDestroy>().bridgeWin = true;
        }

        SceneManager.LoadScene("Platformer Test");
    }

    private void Start()
    {
        GameObject.Find("ScoreSaver").GetComponent<dontDestroy>();
    }
}
