using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveInf : MonoBehaviour
{
    [SerializeField] private GameObject _infClick;
   
    private void OnTriggerEnter(Collider other)
    {
        _infClick.SetActive(true);
        Destroy(_infClick, 2f);
    }
}
