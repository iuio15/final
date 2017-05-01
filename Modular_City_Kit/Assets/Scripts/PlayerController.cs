using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    float speed = 25.0f;
    float rotationSpeed = 50.0f;

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        rb.AddForce(this.transform.forward * translation * 40);
        rb.AddTorque(this.transform.up * rotation * 15);
        AnalogueSpeedConverter.showSpeed(rb.velocity.magnitude, 10, 140);
    }
}
