using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MplusTText : MonoBehaviour
{
    public int i;
    public bool collisiontext;
    public int count;
    public bool win;
    
    // Start is called before the first frame update
    void Start()
    {
        collisiontext = false;
        i = 0;
        count = 0;
        win = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((GameObject.Find("ScoreSaver").GetComponent<dontDestroy>().bridgeWin == true) & (GameObject.Find("ScoreSaver").GetComponent<dontDestroy>().warWin == true) & (GameObject.Find("ScoreSaver").GetComponent<dontDestroy>().duckWin == true) & (GameObject.Find("ScoreSaver").GetComponent<dontDestroy>().hellWin == true))
        {
            win = true;
            
        }
        else
        {
            win = false;
            
        }

        

        if (collisiontext == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (win)
                {
                    if (count < 2)
                    {
                        count = 2;
                    }
                }

                this.gameObject.transform.GetChild(count).gameObject.SetActive(true);
                StartCoroutine(TextAdvance());
                count += 1;

                if (count == 15)
                {
                        StartCoroutine(TextAdvance());
                        SceneManager.LoadScene("End");
                }
                if ((!win) & (count == 2))
                {
                        count = 0;
                        EndDialogue();
                }
                
            }
        }
        if (collisiontext == false)
        {
            EndDialogue();
        }

    }

    

    public void EndDialogue()
    {
        if (collisiontext == false)
        {
            while (i < 10)
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
