using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 distanceAway;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("w") || Input.GetKeyDown("s"))
        {
            Vector3 facing = transform.localEulerAngles;
            facing.y = 90;
            transform.localEulerAngles = facing;
            distanceAway = new Vector3(-10, 10, 0);
        }
        if (Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            Vector3 facing = transform.localEulerAngles;
            facing.y = 0;
            transform.localEulerAngles = facing;
            distanceAway = new Vector3(0, 10, -10);
        }

        transform.position = player.transform.position + distanceAway;
    }
}
