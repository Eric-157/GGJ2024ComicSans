using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDestroy : MonoBehaviour
{
    public static dontDestroy Instance;
    public bool bridgeWin;
    public bool warWin;
    public bool hellWin;
    public bool duckWin;
    public GameObject bridgeTrophy;
    public GameObject warTrophy;
    public GameObject hellTrophy;
    public GameObject duckTrophy;
    public GameObject[] CameraFind;
    public GameObject MainCamera;

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

    private void Update()
    {
        CameraFind = GameObject.FindGameObjectsWithTag("MainCamera");
        MainCamera = CameraFind[0];

        float xPos = MainCamera.transform.position.x;
        float yPos = MainCamera.transform.position.y;

        this.transform.position = new Vector3(xPos, yPos, 0);

        if (bridgeWin == true)
        {
            bridgeTrophy.SetActive(true);
        }
        if (warWin == true)
        {
            warTrophy.SetActive(true);
        }
        if (hellWin == true)
        {
            hellTrophy.SetActive(true);
        }
        if (duckWin == true)
        {
            duckTrophy.SetActive(true);
        }

        CameraFind = null;
    }


}
