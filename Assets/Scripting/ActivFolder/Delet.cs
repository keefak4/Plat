using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delet : MonoBehaviour
{
    [SerializeField] private GameObject[] deletGameObject;
    [SerializeField] private GameObject mainCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < deletGameObject.Length; i++)
            {
                Destroy(deletGameObject[i]);
            }

        }
        mainCamera.SetActive(true);

    }
    
}
