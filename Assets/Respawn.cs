using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform _respawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // On essaye de savoir s'il s'agit du joueur
        if (collision.attachedRigidbody.gameObject.CompareTag("Player"))
        {
            // Si c'est le cas on change la position manuellement
            collision.attachedRigidbody.transform.position = _respawn.position;
        }

    }
}