using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckBox : MonoBehaviour
{
    [SerializeField] Toggle check;
    [SerializeField] Button button;
    
    public void Check()
    {
        button.interactable=check.isOn;
    }
}
