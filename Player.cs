using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player: MonoBehaviour
{
    private int health = 10;
    //Sound Player
    public AudioSource audioSource;
    //File that is supposed to play
    public AudioClip damageSound;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print(health);
        if(health > 0)
        {
            audioSource PlayOneShot(damageSound);
            print("Health of player: " + health);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
