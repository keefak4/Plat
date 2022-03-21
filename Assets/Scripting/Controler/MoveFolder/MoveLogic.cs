using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLogic : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField]private float _power;
   
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        ManagementPlayer managementPlayer = GetComponent<ManagementPlayer>();
        if(managementPlayer._isSwitchPlayer == false)
        {
            MoveHorizontal();
        }
        if(managementPlayer._isSwitchPlayer == true)
        {
            MoveVertical();
        }
    }
    private void MoveHorizontal()
    {
        if(Input.GetKey(KeyCode.D))
        {
            _rigidbody.GetComponent<Rigidbody>().AddForce(transform.right * _power);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.GetComponent<Rigidbody>().AddForce(-transform.right * _power);
        }
    }
    private void MoveVertical()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.GetComponent<Rigidbody>().AddForce(transform.forward * _power);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.GetComponent<Rigidbody>().AddForce(-transform.forward * _power);
        }
    }
}
