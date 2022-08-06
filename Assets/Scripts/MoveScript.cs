using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float moveSpeed = 15f;

    private bool stopMoving = false;
    private bool isBouncing = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Vector3 facing = transform.localEulerAngles;
            facing.y = 90;
            transform.localEulerAngles = facing;
        }
        if (Input.GetKeyDown("s"))
        {
            Vector3 facing = transform.localEulerAngles;
            facing.y = 270;
            transform.localEulerAngles = facing;
        }
        if (Input.GetKeyDown("d"))
        {
            Vector3 facing = transform.localEulerAngles;
            facing.y = 180;
            transform.localEulerAngles = facing;
        }
        if (Input.GetKeyDown("a"))
        {
            Vector3 facing = transform.localEulerAngles;
            facing.y = 0;
            transform.localEulerAngles = facing;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            stopMoving = true;
            float bounce = 600f; //amount of force to apply
            isBouncing = true;
            GetComponent<Rigidbody>().AddForce(other.GetContact(0).normal * bounce);
        }
    }

    void OnCollisionExit(Collision other) {
        stopMoving = false;
    }

    void StopBounce()
    {
        isBouncing = false;
    }

    void FixedUpdate()
    {
        Vector3 pos = transform.position;

        if (!stopMoving)
        {
            if (Input.GetKey("w"))
            {
                pos.z += moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey("s"))
            {
                pos.z -= moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey("d"))
            {
                pos.x += moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey("a"))
            {
                pos.x -= moveSpeed * Time.deltaTime;
            }

            transform.position = pos;
        }
    }
}
