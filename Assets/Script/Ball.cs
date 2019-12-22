using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro Num = default;

    int[] plusminus = new int[] { -1, 1 };
    int Number; //-14 ~ 14 (0を除く)
    public void SetText()
    {
        Number = plusminus[Random.Range(0, 2)] * Random.Range(1, 14);
        Num.text = Number.ToString();
        if (Number < 0){Num.color = Color.red;}
        else{Num.color = Color.black; }
    }

    public void ResetText()
    {
        Number = 0;
        Num.text = "";
    }

    public int GetNumber()
    {
        return Number;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Wall")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0,0,Random.Range(-5, 5)), ForceMode.Impulse);
        }
    }
}
