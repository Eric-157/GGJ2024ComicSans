using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	public bool winCondition = false;
    public int musicScore;
	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU WON!");
		Score.CurrentScore += 100;
        musicScore = Score.CurrentScore;
		if (Score.CurrentScore == 1000)
		{
			winCondition = true;
			Invoke("LoadScene",1);
		} else
		{
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
    private void LoadScene()
    {
        if (GameObject.Find("ScoreSaver").GetComponent<dontDestroy>().warWin != true)
        {
            GameObject.Find("ScoreSaver").GetComponent<dontDestroy>().warWin = true;
        }

        SceneManager.LoadScene("Platformer Test");
    }

    private void Start()
    {
        GameObject.Find("ScoreSaver").GetComponent<dontDestroy>();
    }
}
