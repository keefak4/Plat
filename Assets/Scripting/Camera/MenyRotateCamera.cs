using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenyRotateCamera : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        _rigidbody.AddTorque(Vector3.up * 2f * Time.fixedDeltaTime,ForceMode.Acceleration);
    }
}
