using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIButtons : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;


    /// <summary>
    /// Loads a new scene when called.
    /// </summary>
    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("Scene name is empty, add a scene in the inspector.");
        }
    }
}