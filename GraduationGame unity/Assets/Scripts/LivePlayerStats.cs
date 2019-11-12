﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KinematicTest.controller;

public class LivePlayerStats : MonoBehaviour, IOnSceneReset
{
    public PlayerStats playerStats;
    private bool isDead;

    public float currentHealth;
    public float currentStamina;

    public Vector3 currentSpawnPosition;

    private void Awake()
    {
        currentSpawnPosition = transform.parent.position;
    }
    private void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        Debug.Log(damage + " damage taken");
        playerStats.subtractHealth(damage);
        if (playerStats.getCurrentHealth() <= 0)
        {
            isDead = true;
            Die();
        }
    }

    private void Start()
    {
        OnResetLevel(); //Initialize the player - makes sure the correct skin is loaded too.
    }

    public void Die()
    {
        Debug.Log("git gud");
        GameManager.ChangeGameState(GameStateScriptableObject.GameState.levelLoss);
    }

    public void OnResetLevel()
    {
        currentHealth = playerStats.MaxHealth;
        currentStamina = playerStats.MaxStamina;
        playerStats.resetHealth();
        playerStats.resetStamina();
        isDead = false;

        GetComponentInParent<KinematicTestController>().Motor.SetPosition(currentSpawnPosition);
        playerStats.SetCurrentZoeRecolor(playerStats.selectedSkin); //Ensures that the player sets the selected skin on levelStart 
    }

    public void ChangeSkin(int skinIndex)
    {
        playerStats.SetCurrentZoeRecolor(skinIndex);
    }
}
