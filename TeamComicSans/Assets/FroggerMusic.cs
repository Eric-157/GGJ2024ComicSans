using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroggerMusic : MonoBehaviour
{
    private AudioSource _audioSource;
    public int scoreVal;
    public static FroggerMusic Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
        scoreVal = GameObject.Find("Goal").GetComponent<Goal>().musicScore; 
    }

    private void Update()
    {
        if (scoreVal >= 999) 
        {
            StopMusic();
        }
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
