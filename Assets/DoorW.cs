using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DoorW : MonoBehaviour
{
    [SerializeField] string _sceneNameToLoad;
    [SerializeField] UnityEvent _onFinish;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player.IsPlayer(collision))
        {
            _onFinish.Invoke();
            SceneManager.LoadScene(_sceneNameToLoad);

        }
    }
}
