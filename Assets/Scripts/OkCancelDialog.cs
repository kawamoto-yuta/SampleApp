using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OkCancelDialog : MonoBehaviour
{
    public enum DialogResult
    {
        OK,
        Cancel,
    }

    //ダイアログが操作されたときに発生するイベント
    public Action<DialogResult> FixDialog { get; set; }

    //OKボタンが押されたとき
    public void OnOK()
    {
        this.FixDialog?.Invoke(DialogResult.OK);
        Destroy(this.gameObject);
    }

    //Cancelボタンが押されたとき
    public void OnCancel()
    {
        this.FixDialog?.Invoke(DialogResult.Cancel);
        Destroy(this.gameObject);
    }
}
