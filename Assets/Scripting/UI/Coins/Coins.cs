using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        ManagementPlayer managementPlayer = other.GetComponent<ManagementPlayer>();
        if(managementPlayer != null)
        {
            managementPlayer._coins++;
            Destroy(gameObject);
        }
    }
}
