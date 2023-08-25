using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaillingPlatform : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _timeBeforeFall;
    [SerializeField] float _timeBeforeRespawn;

    Vector3 _initialPosition;
    Coroutine _resetPositionRoutine;


    private void Start()
    {
        _initialPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Player.IsPlayer(collision))
        {
            return;

            // Pour stopper une coroutine on peut appeller cette fonction avec la coroutine concernée
            // StopCoroutine(_resetPositionRoutine);


            //Invoke("ResetPlatforme", 2f); // Ancienne methode
        }
        _resetPositionRoutine = StartCoroutine(FallProcess());
    }

    IEnumerator FallProcess()
    {
        // On laisse le joueur pouvoir sauter sur une seconde
        yield return new WaitForSeconds(_timeBeforeFall);
        // On fait tomber le bloc
        _rb.bodyType = RigidbodyType2D.Dynamic;
        // On marque une attente de 2 secondes ...
        yield return new WaitForSeconds(_timeBeforeRespawn);

        // Puis on remet la plateforme à l'endroit initiale
        _rb.bodyType = RigidbodyType2D.Kinematic;   // Elle ne doit plus réagir aux objets physiques    
        _rb.velocity = Vector3.zero;        // Elle n'a plus de vitesse
        _rb.transform.position = _initialPosition;  // On repositionne 

        // Topo des instructions de coroutine pour marquer une attente
        // yield return null;      // Attendre une frame
        // yield return new WaitForSeconds(2f);      // Attendre 2 secondes
        // yield return new WaitForSecondsRealtime(2f);      // Attendre 2 secondes
        // yield return new WaitForFixedUpdate();          // Attendre la frame physique

        // yield break; // On casse la coroutine, on la force à terminer tout de suite
    }

    void ResetPlatforme()
    {
     //int coucou;

        _rb.bodyType = RigidbodyType2D.Kinematic;
        _rb.velocity = Vector3.zero;

        Invoke("coucou", 1f);
    }

    void coucou()
    {
        _rb.transform.position = _initialPosition;

    }

}