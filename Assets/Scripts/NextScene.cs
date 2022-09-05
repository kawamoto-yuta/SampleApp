using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    [SerializeField] Text txt;
    
    public void Click()
    {
        Debug.Log("Clicked \""+txt.text+"\"");
    }
}
