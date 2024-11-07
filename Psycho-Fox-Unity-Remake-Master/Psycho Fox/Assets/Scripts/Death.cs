using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public  GameObject background;
    public  GameObject deathmusic;
    public Animator ghostanimator;
    public Animator actualanimator;
    public GameObject hitbox;

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "Death") {
            if (hitbox.GetComponent<BoxCollider2D>().enabled == false) {
                background.GetComponent<AudioSource>().Stop();  
                deathmusic.GetComponent<AudioSource>().Play();
                ghostanimator.SetTrigger("Death");
                actualanimator.SetTrigger("Death");
                PlayerManager.Instance.alive = false;
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                print("You just died");
            }
            
        }
    }
}
