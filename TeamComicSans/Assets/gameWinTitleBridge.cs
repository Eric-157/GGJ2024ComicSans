using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameWinTitleBridge : MonoBehaviour
{
    public splat splatscript;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Chicken").GetComponent<splat>().winCondition == true)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
