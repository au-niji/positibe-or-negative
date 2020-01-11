using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonManager : MonoBehaviour
{
    //ゲーム時のボタンの有効化、無効化を管理します。

    [SerializeField]
    private Button Bt_Minus;
    [SerializeField]
    private Button Bt_Zero;
    [SerializeField]
    private Button Bt_Plus;
    [SerializeField]
    private Button Bt_Pause;
    public void DisableMainButton()
    {
        //ボタンを押せなくします。
        Bt_Minus.interactable = false;
        Bt_Zero.interactable  = false;
        Bt_Plus.interactable  = false;
        Bt_Pause.interactable = false;
    }
    public void EnableMainButton()
    {
        //ボタンを押せるようにします。
        Bt_Minus.interactable = true;
        Bt_Zero.interactable  = true;
        Bt_Plus.interactable  = true;
        Bt_Pause.interactable = true;
    }

} 