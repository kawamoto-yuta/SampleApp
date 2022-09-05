using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallingDialog : MonoBehaviour
{
    // [SerializeField] Text txt;
    [SerializeField] Canvas dialog;
    [SerializeField] Text dialogTitle;
    [SerializeField] Text buttonText;
    [SerializeField] Text mainText;
    
    public void Start()
    {
        dialog.enabled=false;
    }
    
    public void Click()
    {
        // Debug.Log("Clicked \""+txt.text+"\"");
        dialog.enabled=true;
        dialogTitle.text=buttonText.text;
        mainText.text="";
        for(int i=0;i<30;i++)
        {
            mainText.text+=buttonText.text+(i+1)+"\n";
        }
    }
}
