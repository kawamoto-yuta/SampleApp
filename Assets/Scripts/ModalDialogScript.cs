using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModalDialogScript : MonoBehaviour
{
    [SerializeField] Canvas dialog;

    public void Click()
    {
        dialog.enabled=false;
    }
}
