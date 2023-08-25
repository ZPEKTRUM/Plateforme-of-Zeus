using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DoorW : MonoBehaviour
{
    [SerializeField] InputActionReference _nextInput;
    [SerializeField] string _sceneName;

    private void Update()
    {
        // On attend que l'input de fin de niveau est appuyé pile sur cette update
        if (_nextInput.action.WasPressedThisFrame())
        {
            // Puis on lance la scene
            SceneManager.LoadScene("_SampleScene");
        }
    }

}