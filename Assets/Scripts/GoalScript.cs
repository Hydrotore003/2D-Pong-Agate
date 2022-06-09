using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public Collider2D Ball;
    public bool isRight;
    public ScoreManager manager;
    //public ballcontrol resetball;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == Ball)
        {
            if (isRight)
            {
                manager.AddRightScore(1);
                //resetball.ResetBall();
            }
            else
            {
                manager.AddLeftScore(1);
                //resetball.ResetBall();
            }
        }
    }
}
