using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayerControler : MonoBehaviour
{
    [SerializeField] private GameObject _clickButtomSwichPlayerControl;
    [SerializeField] private GameObject _PlayerObject;
    private void OnTriggerEnter(Collider other)
    {
        ManagementPlayer managementPlayer = other.GetComponent<ManagementPlayer>();

        if(managementPlayer)
        {
            managementPlayer._isSwitchPlayer = true;
            if (managementPlayer._isSwitchPlayer == true)
            {
                _clickButtomSwichPlayerControl.SetActive(true);
                Destroy(_clickButtomSwichPlayerControl, 3f);
                _PlayerObject.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            }
        }
    }
}
