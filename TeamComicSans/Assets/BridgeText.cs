using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BridgeText : MonoBehaviour
{
    public int i;
    public bool collisiontext;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        collisiontext = false;
        i = 0;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if ( collisiontext == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
        {
                if (GameObject.Find("ScoreSaver").GetComponent<dontDestroy>().bridgeWin != true)
                {
                    this.gameObject.transform.GetChild(count).gameObject.SetActive(true);
                    StartCoroutine(TextAdvance());
                    count += 1;
                    if (count == 7)
                    {
                        StartCoroutine(TextAdvance());
                        SceneManager.LoadScene("Bridge");
                    }
                }
        }
        }
        if ( collisiontext == false )
        {
            EndDialogue();
        }
        
    }

    

    public void EndDialogue()
    {
        if (collisiontext == false)
        {
            while (i < 7)
            {
                this.gameObject.transform.GetChild(i).gameObject.SetActive(false);
                
                i++;
                
                
            }
            i = 0;
        }
    }

    private IEnumerator TextAdvance()
    {
        yield return new WaitForSeconds(10);
        count += 1;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collisiontext = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collisiontext = false;
        count = 0;
    }

    
}
