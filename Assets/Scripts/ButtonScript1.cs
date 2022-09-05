using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript1 : MonoBehaviour
{
    // [SerializeField] Text txt;
    [SerializeField] Canvas dialog;
    
    public void Start()
    {
        dialog.enabled=false;
    }
    
    public void Click()
    {
        // Debug.Log("Clicked \""+txt.text+"\"");
        dialog.enabled=true;
    }
}
