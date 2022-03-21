using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayCamera : MonoBehaviour
{
    [SerializeField] private GameObject _IconGameObject;
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _IconGameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(_IconGameObject);
        }
    }
}
