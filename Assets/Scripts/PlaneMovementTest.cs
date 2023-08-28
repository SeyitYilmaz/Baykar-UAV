using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovementTest : MonoBehaviour
{
    float movementSpeed = 2f;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 direction = new Vector3(-15, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        Quaternion targetRotation = Quaternion.Euler(direction);
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * movementSpeed);
    }

    void MovePlane()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
    }
}
