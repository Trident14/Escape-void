using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class KillOnTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        // check if the collusioin is player
        if(collision.collider.CompareTag("Player"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        }
    }
}
