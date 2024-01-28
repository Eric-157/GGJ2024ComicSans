using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	public static bool frogwin = false;
	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU WON!");
		Score.CurrentScore += 100;
		if (Score.CurrentScore == 1000)
		{
			frogwin = true;
			SceneManager.LoadScene("Platformer Test");
		} else
		{
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}

}
