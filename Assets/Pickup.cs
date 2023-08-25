using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    //private Intvariable _beersCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player.IsPlayer(collision))
        {
            ScoreManager.instance.AddScore(100);

            //_beersCollected.m_value++;

        }
    }
}
