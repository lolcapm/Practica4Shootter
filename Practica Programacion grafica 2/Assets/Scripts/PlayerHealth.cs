using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    /*public float startingHealth = 100;                            // The amount of health the player starts the game with.
    public float currentHealth;
    public Slider healthSlider;    
    public Image damageImage; 

    public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public GameObject muereSoldado;                             // The colour the damageImage is set to, to flash.


    Animator anim;

    

    bool isDead;                                                // Whether the player is dead.
    bool damaged;
	// Use this for initialization

    void Awake()
    {
        anim = GetComponent<Animator>();
        currentHealth = startingHealth;
    }

    void Update()
    {
        if (damaged)
        {
            
            damageImage.color = flashColour;
        }
     
        else
        {
      
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        damaged = false;
    }

    public void TakeDamage(int amount)
    {
       
        damaged = true;

       
        currentHealth -= amount;

       
        healthSlider.value = currentHealth;

   ;

        
        if (currentHealth <= 0 && !isDead)
        {
            
            Death();
        }
    }


    void Death()
    {
        isDead = true;
        anim.SetTrigger("Die");
        Instantiate(muereSoldado, transform.position, transform.rotation);
        Destroy(gameObject);
    }


    public void RestartLevel()
    {
        
        SceneManager.LoadScene(0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            currentHealth -= 10;
        }
    }*/
    public float maxSalud;
    public float curSalud;

   // AudioSource playerAudio;


    void Awake()
    {
        //playerAudio = GetComponent<AudioSource>();

        curSalud = maxSalud;
    }
    void Update()
    {
        if (curSalud <= 0)
        {
            //playerAudio.clip = deathClip;
            //playerAudio.Play();
            Debug.Log(":v");
            SceneManager.LoadScene("Perdiste");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ObjetoADestruir1"))
        {
            curSalud -= 10;
        }
    }
}
