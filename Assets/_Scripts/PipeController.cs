using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField]
    private float pipe_speed;
    [SerializeField]
    private float upDownSpeed;

    private Rigidbody2D pipe_rigidbody;

    public void Start()
    {
        pipe_rigidbody = GetComponent<Rigidbody2D>();
        MovePipe();

        InvokeRepeating("switchUpDown", 0.1f, 1f);
    }

    public void switchUpDown()
    {
        upDownSpeed = -upDownSpeed;
        pipe_rigidbody.velocity = new Vector2(pipe_speed, upDownSpeed);
    }

    public void MovePipe()
    {
        pipe_rigidbody.velocity = new Vector2(pipe_speed, upDownSpeed);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pipeBoundary"))
        {
            Destroy(gameObject);
        }
    }




}//pipe controller class
