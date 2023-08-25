using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour

{


    #region Exposed

    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _smooth = 5f;

    [SerializeField]
    private float _offsetZ = -10f;

    #endregion

    #region Unity Lifecycle

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        //déplacer le joueur

        //deplacment de la caméra 

        Vector3 targetPosition = new Vector3(_target.position.x, _target.position.y, _offsetZ);

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * _smooth);
    }

    #endregion
}