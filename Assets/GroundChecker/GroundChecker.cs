using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] bool _isGrounded;
    [SerializeField] int _groundContactNumber;
    [SerializeField] UnityEvent _onGrounded;

    public bool IsGrounded { get => _isGrounded; }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (_isGrounded == false && Time.time > 1f)
            {
                _onGrounded.Invoke();
            }

            _isGrounded = true;
            _groundContactNumber++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _groundContactNumber--;
            if (_groundContactNumber <= 0)
            {
                _isGrounded = false;
            }
        }


    }

}