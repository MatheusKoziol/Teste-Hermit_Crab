using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    Rigidbody2D rb2d;


    //Public variables
    public float thrustForce;
    public int score;

    #region Singleton

    public static PlayerController instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
            Thrust();
        }
    }

    /// <summary>
    /// Function that applies an upwards force on the player
    /// </summary>
    public void Thrust()
    {
        rb2d.velocity = new Vector2(0f, 0f);
        rb2d.AddForce(new Vector2(0f, thrustForce), ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damage"))
        {
            CanvasScript.instance.EndGame();
        }

        if (collision.CompareTag("Point"))
        {
            score += 10;
        }
    }
}
