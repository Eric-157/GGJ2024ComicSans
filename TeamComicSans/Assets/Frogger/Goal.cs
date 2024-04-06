using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	public bool winCondition = false;
	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU WON!");
		Score.CurrentScore += 100;
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
		SceneManager.LoadScene("Platformer Test");
	}
}
