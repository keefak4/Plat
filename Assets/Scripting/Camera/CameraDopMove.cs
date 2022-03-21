using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDopMove : MonoBehaviour
{
    [SerializeField] private float _offset;
    [SerializeField] private Transform _target;
    private void Update()
    {
        transform.position = new Vector3(_target.transform.position.x - _offset, 1, 0);
    }
}
