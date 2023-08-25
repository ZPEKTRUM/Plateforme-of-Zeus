using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCubeGizmos : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(transform.position, Vector3.one * 2);
    }

}