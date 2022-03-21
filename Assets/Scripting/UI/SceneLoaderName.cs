using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoaderName : MonoBehaviour
{
    [SerializeField] private string _nameScene;
    public void LoadSceneClick()
    {
        SceneManager.LoadScene(_nameScene);
    }
}
