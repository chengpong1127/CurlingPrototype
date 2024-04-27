using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurlingStoneController : MonoBehaviour
{
    Rigidbody rb;
    Transform tf;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
    }

    void Update()
    {
        // Only keep the rotation around the Y axis
        tf.rotation = Quaternion.Euler(0, tf.rotation.eulerAngles.y, 0);
    }
}
