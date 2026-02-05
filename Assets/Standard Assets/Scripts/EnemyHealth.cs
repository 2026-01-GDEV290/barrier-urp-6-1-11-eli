using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour {

    public int startingHealth;                            // The amount of health the player starts the game with.
    public int currentHealth;                                   // The current health the player has.
    

    bool isDead;                                                // Whether the player is dead.
    bool damaged;                                               // True when the player gets damaged.

    void Awake()
    {
        // Set the initial health of the player.
        currentHealth = startingHealth;
        

    }
    
    // Update is called once per frame
    void Update()
    {


        if (currentHealth <= (0))

        {

            Destroy(gameObject);
        }

    }

    public void HurtEnemy(int amount)
    {

        // Reduce the current health by the damage amount.
        currentHealth -= amount;

    }

    public void SetStartingHealth()
    {
        currentHealth = startingHealth;
    }




}