using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickDamage : MonoBehaviour
{

    GameObject enemy;                          // Reference to the player GameObject.
    EnemyHealth enemyHealth;                    // Reference to this enemy's health.
    bool enemyInRange;                         // Whether player is within the trigger collider and can be attacked.

    public int damagePerClick;



    void Start()
    {
        // Setting up the references.
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemyHealth = GetComponent<EnemyHealth>();

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.tag == "Enemy")
        {
            if (Input.GetMouseButtonDown(0))
                gameObject.GetComponent<EnemyHealth>().HurtEnemy(damagePerClick);
        }

    }

}