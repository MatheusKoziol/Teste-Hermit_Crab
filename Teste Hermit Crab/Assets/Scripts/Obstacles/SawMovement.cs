using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMovement : MonoBehaviour
{

    public Vector3 initialPosition;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1f, 0f, 0f) * speed * Time.deltaTime);

        if (transform.position.x < -18.58f)
        {
            gameObject.SetActive(false);
        }
    }
}
