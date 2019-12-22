using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]
    private GameObject OBJ_Pause = default;
    public void OnClick(bool OnOff)
    {
        OBJ_Pause.SetActive(OnOff);
    }
}
