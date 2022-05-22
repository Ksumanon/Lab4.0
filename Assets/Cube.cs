using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Redcode.Extensions;
public class Cube : MonoBehaviour
{
    public float jumpForce = 20;
    float velocity;
    public float gravityScale = 5;
    public float gravity = -9.81f;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.SetPositionZ(transform.position.z + 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.SetPositionZ(transform.position.z - 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.SetPositionX(transform.position.x + 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.SetPositionX(transform.position.x - 7f * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.SetPositionY(transform.position.y + 15f * Time.deltaTime);
        }
        
    }
}