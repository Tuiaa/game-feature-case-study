using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiUtils : MonoBehaviour
{

    [SerializeField] private GameObject _buttonParent;
    
    void Start()
    {

    }

    
    void Update()
    {
        
    }

    void DisplayButtonsOnTopOfField(Vector3 fieldPosition, GameObject button)
    {
        var pos = Camera.main.WorldToScreenPoint(fieldPosition);

        button.transform.position = pos;
    }
}
