using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayerControler : MonoBehaviour
{
    [SerializeField] private GameObject _clickButtomSwichPlayerControl;
    [SerializeField] private GameObject _PlayerObject;
    private void OnTriggerEnter(Collider other)
    {
        HorAndMove managementPlayer = other.GetComponent<HorAndMove>();

        if(managementPlayer)
        {
            managementPlayer._isSwitchPlayer = true;
            if (managementPlayer._isSwitchPlayer == true)
            {
                _clickButtomSwichPlayerControl.SetActive(true);
                 Destroy(_clickButtomSwichPlayerControl, 1.2f);
                _PlayerObject.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            }
        }
    }
}
