using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeButtonScript : MonoBehaviour
{
    [SerializeField] Text txt;
    
    public void Click()
    {
        Debug.Log("Clicked \""+txt.text+"\"");
    }
}
