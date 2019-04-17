using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    private void Update()
    {
        float amount = 0;
        if (Input.GetKey(KeyCode.W))
            amount = speed;
        else if (Input.GetKey(KeyCode.S))
            amount = -speed;

        transform.Translate(Vector3.forward * Time.deltaTime * amount, Space.Self);
    }

}
