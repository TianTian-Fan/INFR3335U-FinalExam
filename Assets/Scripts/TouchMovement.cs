using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    public FixedJoystick joystick;
    public FixedJoystick lookJoystick;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hoz = joystick.Horizontal;
        float ver = joystick.Vertical;

        Vector3 direction = new Vector3(hoz, 0, ver).normalized;
        transform.Translate(direction * 0.005f, Space.World);

        float rotateHoz = lookJoystick.Horizontal * 0.1f;
        transform.Rotate(0, rotateHoz, 0);
    }
}
