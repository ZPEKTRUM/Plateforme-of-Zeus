using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour
{
    [SerializeField] SpriteRenderer _renderer;
    [SerializeField] Sprite _openDoorSprite;
    [SerializeField] GameObject _canvasToActivate;
    [SerializeField] float _waitBeforeMenuDisplay;

    [SerializeField] UnityEvent _onFinishedLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player.IsPlayer(collision))
        {
            StartCoroutine(OpenRoutine());
        }
    }

    IEnumerator OpenRoutine()
    {
        // On change le sprite
        _renderer.sprite = _openDoorSprite;

        // On attend X secondes
        yield return new WaitForSeconds(_waitBeforeMenuDisplay);

        // On peut activer le canvas et enclencher l'event de fin de niveau si besoin
        _canvasToActivate.SetActive(true);
        _onFinishedLevel.Invoke();
    }



}