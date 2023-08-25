using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

internal enum WaypointMode // énumérer les possibilités
{
    LOOP,
    PINGPONG,
}

public class waypointplateform : MonoBehaviour
{

    [SerializeField]
    private WaypointMode _mode = WaypointeMode.LOOP;

    //Tableau de position dans l' espace

    [SerializeField]
    private Transform[] _waypoints;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _reachTolerance = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = _waypoints[0].position;
        _targetWaypointIndex = 1; //index 0

    }

    // Update is called once per frame
    void Update()
    {
        //je suis et je vais

        {
            Vector3 currenWaypointPosition = _waypoints[_targetWaypointIndex].position;
            Vector3 position = Vector3.MoveTowards(transform.position, _waypoints[_targetWaypointIndex + 1].position, _speed * Time.deltaTime);
            transform.position = position;

            if (Vector3.Distance(transform.position, _waypoints[_targetWaypointIndex].position) < _reachTolerance)
            {
                switch (_mode)
                {
                    case WaypointMode.LOOP:
                        Loop();

                        if (_targetWaypointIndex >= _waypoints.Length)

                        {

                            _targetWaypointIndex = 0;
                        }

                        break;
                    case WaypointMode.PINGPONG:
                        PingPong();
                        break;

                }


            }
        }

    }

    private void FixedUpdate()
    {

    }

    private void Loop()

    {
        if (_targetWaypointIndex >= _waypoints.Length)

        {

            _targetWaypointIndex = 0;
        }

    }

    private void PingPong()

    {

        if (_isForward)

        {
            _targetWaypointIndex++; //si je suis vers l' avant, j' incrémente, 1,2,3++

            if (_targetWaypointIndex >= _waypoints.Length - 1) //end tab
            {
                _isForward = false; //inversion
            }
        }

        else

        {
            _targetWaypointIndex--; //-1

            if (_targetWaypointIndex <= 0)
            {
                _isForward = true;
            }

        }


    }

    private int _targetWaypointIndex;
    private bool _isForward = true; //je vais vers l' avant

    public object aypointmode { get; private set; }
}

internal class WaypointPlatform
{
}

internal class WaypointeMode
{
    public static WaypointMode LOOP { get; internal set; }
}

