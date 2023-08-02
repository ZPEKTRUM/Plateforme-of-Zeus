using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Camera _camera;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] InputActionReference _moveInput;
    [SerializeField] InputActionReference _jumpInput;

    [Header("Configuration")]
    [SerializeField] float _movementSpeed;
    [SerializeField] float _jumpPower;

    public static Controls Instance
    {
        get; private set;
    }
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("OMG");
        }

        Instance = this;
    }

    // Move the player
    void Update()
    {
        if (_jumpInput.action.WasPressedThisFrame())
        {
            _rb.AddForce(new Vector2(0, _jumpPower));
        }

        // On récupère la direction droite/gauche du joystick que l'on augmente par la vitesse
        float xAxis = _moveInput.action.ReadValue<Vector2>().x * _movementSpeed;

        // On fourni une nouvelle velocité avec notre direction à nous MAIS 
        // en conservant la vitesse de chute de l'objet pour que la gravité s'accumule progressivement.
        _rb.velocity = new Vector2(xAxis, _rb.velocity.y);
    }
}


