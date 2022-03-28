using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorAndMove : MonoBehaviour
{
    public bool _isSwitchPlayer = false;
    [SerializeField] private MoveLogic moveLogic;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _isSwitchPlayer = false;
            moveLogic.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            _isSwitchPlayer = true;
            moveLogic.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }

    }
}
