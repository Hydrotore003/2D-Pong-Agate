using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpeedUPController : MonoBehaviour
{
    public Collider2D Ball;
    public Collider2D Paddle1;
    public Collider2D Paddle2;
    public float magnitude;
    public PowerUpManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == Ball)
        {
            Paddle1.GetComponent<paddlecontrol>().ActivatePaddleSpeed(magnitude);
            Paddle2.GetComponent<paddlecontrol>().ActivatePaddleSpeed(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
