using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameWinTitle : MonoBehaviour
{
    public splat splatscript;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Chicken").GetComponent<splat>().spriteChanged == true)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
