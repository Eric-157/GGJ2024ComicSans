using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    public static dontDestroy Instance;
    public bool bridgeWin;
    public bool warWin;
    public bool hellWin;
    public bool duckWin;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        bridgeWin = false;
        warWin = false; 
        hellWin = false;
        duckWin = false;


    }

}
