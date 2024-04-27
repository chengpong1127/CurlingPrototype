using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurlingStoneController : MonoBehaviour
{
    Rigidbody rb;
    public Transform controller;
    float speed = 10f;
    private bool isHeld = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
            Vector3 force = new Vector3(0, 0, 1) * speed;
            rb.AddForce(force);
        }
    }
}
