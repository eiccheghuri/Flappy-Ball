using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private Rigidbody2D ball_rigidbody;
    [SerializeField]
    private float jump_force;
    private bool is_started;
    private bool is_gameOver;

    public void Start()
    {
        is_gameOver = false;
        ball_rigidbody = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        if(!is_started)
        {
            if(Input.GetMouseButtonDown(0))
            {
                is_started = true;
                ball_rigidbody.isKinematic = false;
                

            }
        }
        else
        {
            addBallForce();

        }


    }


    public void addBallForce()
    {

        if(Input.GetMouseButtonDown(0))
        {
            ball_rigidbody.velocity = Vector2.zero;
            ball_rigidbody.AddForce(new Vector2(0,jump_force));
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {


        if(collision.gameObject.CompareTag("pipe"))
        {
            is_gameOver = true;
            gameOver();
            
        }



        if(!is_gameOver)
        {
            if (collision.gameObject.CompareTag("score"))
            {
                ScoreManager.instance.ScoreIncrementScore();
            }
        }
        


       
    }

    public void gameOver()
    {
        
        ScoreManager.instance.StopIncrementScore();
        UiManager.instance.GameOVer();

    }




}//ball controller class



