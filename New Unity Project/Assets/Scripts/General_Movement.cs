using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General_Movement : MonoBehaviour {

    private Transform tf;
    private Vector3 warpPos;

    public float rotationSpeed;
    public float linearSpeed;

    // Use this for initialization
    void Start()
    {

        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {

            tf.Rotate(0, 0, 1 * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {

            tf.Rotate(0, 0, -1 * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {

            tf.position += tf.up * linearSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {

            tf.position -= tf.up * linearSpeed;
        }
    }
}
