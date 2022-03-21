using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadArrow : MonoBehaviour
{
    [SerializeField]private GameObject _VectorUpBlock;
    private void OnMouseDown()
    {
        _VectorUpBlock.SetActive(true);
        GetComponent<MeshRenderer>().enabled = false;
    }
}
