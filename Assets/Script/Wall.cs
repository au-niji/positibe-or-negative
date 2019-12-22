using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField]
    private float m_power = 0.0f;
    [SerializeField]
    private Vector3 m_powerDir = Vector3.zero;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            //ぶつかってきたボールに垂直に力を与える
            other.gameObject.GetComponent<Rigidbody>().AddForce(m_powerDir.normalized * m_power, ForceMode.Impulse);
        }
    }
}
