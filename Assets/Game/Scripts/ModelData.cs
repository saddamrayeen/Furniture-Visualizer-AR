using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModelData : MonoBehaviour
{
    [SerializeField] GameObject model;
    public static GameObject SELECTED_MODEL;

   
    public void ChangeScene()
    {
        SELECTED_MODEL = model;
        SceneManager.LoadScene(1);
    }
}
