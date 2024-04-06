using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameWinTitleDuck : MonoBehaviour
{
    public DuckGoal duckgoalscript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Goal").GetComponent<DuckGoal>().winCondition == true)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
