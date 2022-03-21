using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockActiv : MonoBehaviour
{
    [SerializeField] private GameObject _block;
  
    private void OnMouseDown()
    {
        _block.gameObject.SetActive(true);

        Destroy(gameObject);
    }
}
