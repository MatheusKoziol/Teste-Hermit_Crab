using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{

    public Vector3 initialPosition;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1f, 0f, 0f) * speed * Time.deltaTime);

        if(transform.position.x < -18.58f)
        {
            transform.position = initialPosition;
        }
    }
}
