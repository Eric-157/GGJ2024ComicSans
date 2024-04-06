using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameWinTitleBulletHell : MonoBehaviour
{
    public survive survivescript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("survive").GetComponent<survive>().winCondition == true)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
