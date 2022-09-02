using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckBox : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awaked");
    }

    void OnEnable()
    {
        Debug.Log("Enabled");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Upadated");
    }

    public void Check()
    {
        Button button=GameObject.Find("Button3").GetComponent<Button>();
        bool ison=GetComponent<Toggle>().isOn;
        button.interactable=ison;
        Debug.Log("Checked = "+ison);
    }
}
