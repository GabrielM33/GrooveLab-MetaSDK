using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateDeactivate : MonoBehaviour
{
    public GameObject prefabActivated;
    public bool isEnabled = false;

    public GameObject[] prefabDeactivated;

    
    public void ButtonClicked() {
        isEnabled = !isEnabled;
        prefabActivated.SetActive(isEnabled);
    }

    public void DisablePrefab()
    {
        isEnabled = false;
        foreach (GameObject prefab in prefabDeactivated)
        {
            prefab.SetActive(false);
        }
    }
}
