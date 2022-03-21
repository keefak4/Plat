using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMainMove : MonoBehaviour
{
   [SerializeField] private Transform _target;
    private void Update()
    {
        transform.position = new Vector3(_target.transform.position.x, 0, -10);
    }
}
