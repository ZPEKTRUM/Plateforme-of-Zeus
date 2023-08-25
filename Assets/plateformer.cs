using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateformer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody.gameObject.CompareTag("Player"))
        {
            collision.attachedRigidbody.transform.SetParent(transform);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.attachedRigidbody.gameObject.CompareTag("Player"))
        {
            collision.attachedRigidbody.transform.SetParent(null);
        }

    }


}