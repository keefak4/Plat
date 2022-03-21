using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIPlayer : MonoBehaviour
{
    [SerializeField] private Text _textCoins;
    [SerializeField] private ManagementPlayer _managementPlayer;
    
    private void Update()
    {
        _textCoins.text = _managementPlayer._coins.ToString();
    }
}
