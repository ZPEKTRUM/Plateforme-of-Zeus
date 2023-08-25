using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    [SerializeField] int _currentHealth;

    internal void TakeDamage(int damage)
    {
        _currentHealth -= damage;

        if(_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
