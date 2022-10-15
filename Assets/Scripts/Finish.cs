using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Finish : MonoBehaviour
{

    private AudioSource finishSound;

    private bool levelComplated = false;
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelComplated) ;
        {
           
            finishSound.Play();
            levelComplated = true;
            Invoke("CompleteLevel" , 1f);
        }
    }

    private void  CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
