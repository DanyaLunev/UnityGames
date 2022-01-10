using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float needlespeed;

    void Update()
    {
        if (Input.touchCount > 0) Swipe();
    }

    void Swipe()
    {
        Vector2 delta = Input.GetTouch(0).deltaPosition;

        if (delta.x > 0)
        {
            Vector3 position = transform.position;
            position.x += needlespeed;
            transform.position = position;
        }
        else
        {
            Vector3 position = transform.position;
            position.x -= needlespeed;
            transform.position = position;
        }

        if (delta.y > 0)
        {
            Vector3 position = transform.position;
            position.z += needlespeed;
            transform.position = position;
        }
        else
        {
            Vector3 position = transform.position;
            position.z -= needlespeed;
            transform.position = position;
        }
    }
}
