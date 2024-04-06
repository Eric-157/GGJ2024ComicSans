using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ducky : MonoBehaviour
{
    public Rigidbody2D duck;
    public AudioClip quack;
    private AudioSource audioSource;
    // Update is called once per frame
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            duck.MovePosition(duck.position + Vector2.right/20);
            audioSource.Play();
        }
    }
}
