﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    public float PlayerHP = 100;
    public RectTransform healthBar;
    private float CurrentHealth;
	// Use this for initialization
	void Start () {
        CurrentHealth = PlayerHP;
	}

    public void TakeDamage(float amount)
    {
        CurrentHealth -= amount;
        if (CurrentHealth <= 0 )
        {
            CurrentHealth = 0;
            //add player objects name with a public
            Debug.Log("PLAYER DEAD");
        }
        if (CurrentHealth > 100)
        {
            CurrentHealth = 100;
        }
        healthBar.sizeDelta = new Vector2(CurrentHealth, healthBar.sizeDelta.y);
       
    }
}