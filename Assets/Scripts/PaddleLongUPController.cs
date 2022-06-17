using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleLongUPController : MonoBehaviour
{
    public Collider2D Ball;
    public float magnitude;
    public Collider2D Paddle1;
    public Collider2D Paddle2;
    public PowerUpManager manager;
    public Vector2 BallDirection;

    //private void Update()
    //{
    //    BallSpeedGet(BallDirection);
    //}

    //private void BallSpeedGet(Vector2 BallVelocity)
    //{
    //    BallDirection = GetComponent<ballcontrol>().BallVelocity;
    //    Debug.Log("Velocity =" + BallDirection.x);
    //}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision == Ball)
        {
            Paddle1.GetComponent<paddlecontrol>().ActivatePaddleSize(magnitude);
            Paddle2.GetComponent<paddlecontrol>().ActivatePaddleSize2(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
