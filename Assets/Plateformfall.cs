using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateformefall : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _timeBeforeall;
    [SerializeField] float _timeAfterall;
    [SerializeField] float _timeBeforespawn;

    Vector3 _initalPosition;

    public float force = 10f; // la force d'impulsion à appliquer à la plateforme
    private Rigidbody2D rb; // le rigidbody de la plateforme
    private Vector3 _initialPosition; // la position initiale de la plateforme
    private Coroutine resetRoutine; // une variable pour stocker la référence à la coroutine
    private RigidbodyType2D rigidbodyType2D;

    private Player _player;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // on récupère le rigidbody
        _initialPosition = rb.transform.position; // on initialise la position initiale
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _player = collision.gameObject.GetComponent<Player>();
            if (_player != null)
            {
                //on laisse le joueur pouvoir sauter uen seconde
                StartCoroutine(FallProcess());
            }
        }
    }

    IEnumerator FallProcess()
    {
        yield return new WaitForSeconds(_timeBeforeall);
        //On fait tomber le bloc
        rigidbodyType2D = rb.bodyType;
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.isKinematic = true;
        yield return new WaitForSeconds(_timeAfterall);
        yield return new WaitForSeconds(force);
        yield return new WaitForSeconds(_timeBeforespawn);

        //puis on remet la plateforme à l' endroit initiale
        rb.bodyType = rigidbodyType2D;
        rb.velocity = Vector3.zero;
        rb.transform.position = _initialPosition;
    }

    private void ResetPlateforme()
    {
        rb.bodyType = rigidbodyType2D;
        rb.velocity = Vector3.zero;
    }
}