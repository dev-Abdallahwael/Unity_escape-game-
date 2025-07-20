using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private static int currentLevel = 1;
    private int health = 100;
    private int score = 0;
    public Text healthText, scoreText;
    public Slider healthSlider;
    public Camera myCamera;
    private AudioSource s;
    public AudioClip attackSound, collectSound;

    public void Start(){
        s = myCamera.GetComponent<AudioSource>();
    }

    public void takeDamage(){
        health -= 20;
        healthText.text = "Health "+health+"%";
        healthSlider.value = health/100f;
        s.PlayOneShot(attackSound);

        if(health == 0){
            SceneManager.LoadScene("LOSE");
        }
    }

    public void OnTriggerEnter(Collider x){
        if(x.tag == "pickup"){
            s.PlayOneShot(collectSound);
            score++;
            scoreText.text = "Score: "+score;
            x.gameObject.SetActive(false);

            if(score == 8){
                SceneManager.LoadScene("WIN");

            }
        }
    }
}
