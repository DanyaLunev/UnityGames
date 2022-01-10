using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointParent : MonoBehaviour
{
    public GameObject part_of_coookie;
    private float movementSpeed = 1f;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Needle")
        {
            part_of_coookie.transform.parent = gameObject.transform;

            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

            if (transform.position.x > 0f && transform.position.z > 0f)
            {
                gameObject.transform.Translate(Random.Range(1, 3), 0, Random.Range(1, 3));
            }

            if (transform.position.x < 0f && transform.position.z < 0f)
            {
                gameObject.transform.Translate(Random.Range(-1, -3), 0, Random.Range(-1, -3));
            }

            if (transform.position.x > 0f && transform.position.z < 0f)
            {
                gameObject.transform.Translate(0, 0, Random.Range(-1, -3));
            }

            if (transform.position.x < 0f && transform.position.z > 0f)
            {
                gameObject.transform.Translate(Random.Range(1, 3), 0, 0);
            }
        }

        if (other.tag == "Fail")
        {
            part_of_coookie.transform.parent = gameObject.transform;
            gameObject.transform.Translate(Random.Range(-3, 3), 0, Random.Range(-3, 3));
        }
    }
}
