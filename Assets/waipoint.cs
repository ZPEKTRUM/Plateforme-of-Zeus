using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint : MonoBehaviour
{
    enum Mode { Loop, PingPong }


    [SerializeField] List<Transform> _points;
    [SerializeField] int _destinationIndex;
    [SerializeField] Mode _mode;
    [SerializeField]
    private float _speed;

    bool _reverse;

    private void Update()
    {
        Transform dest = _points[_destinationIndex];

        Vector3 direction = dest.position - transform.position;

        direction.Normalize();
        direction *= 0.1f;

        // est-ce que l'on est arrivé
        var distance = Vector3.Distance(dest.position, transform.position);
        if (distance < 2f)
        {
            Debug.Log("arrivé");

            if (_mode == Mode.Loop)
            {
                //Loop
                _destinationIndex++;
                if (_destinationIndex >= _points.Count)
                {
                    _destinationIndex = 0;
                }
            }
            else if (_mode == Mode.PingPong)
            {
                // Ping-pong
                if (_reverse == false)
                {
                    _destinationIndex++;
                    if (_destinationIndex >= _points.Count)
                    {
                        _reverse = true;
                        _destinationIndex--;
                    }
                }
                else
                {
                    _destinationIndex--;
                    if (_destinationIndex < 0)
                    {
                        _reverse = false;
                        _destinationIndex++;
                    }
                }
            }
        }
        else
        {
            transform.Translate(direction);
        }

    }

}