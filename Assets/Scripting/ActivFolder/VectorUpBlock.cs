using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorUpBlock : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(transform.up * 50f);
        Destroy(gameObject,1f);
    }
}
