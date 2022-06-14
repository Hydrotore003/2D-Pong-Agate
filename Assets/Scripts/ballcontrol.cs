using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rig;
    public Vector2 resetPosition;

    private void Start()
    {
        float[] valuesX = new float[] { -10f, -9f, -8f, -7f, -6f, -5f, -4f, -3f, 3f, 4f, 5f, 6f, 7f, 8f, 9f, 10f };
        float[] valuesY = new float[] { -5f, -4f, -3f, -2f, -1f, 1f, 2f, 3f, 4f, 5f };

        float randX = valuesX[Random.Range(0, valuesX.Length)];
        float randY = valuesY[Random.Range(0, valuesY.Length)];

        //if (randX > 5)
        //{
        //    randY = Random.Range(0f, 5f);
        //}
        //else if (randX < 5)
        //{
        //    randY = Random.Range(5f, 10f);
        //}

        speed = new Vector2(randX, randY);
        rig = GetComponent<Rigidbody2D>();

        Move();
        //Invoke("Move", 2);
    }

    private void Move()
    {
        rig.velocity = speed;
    }

    private void Update()
    {
        //Debug.Log("Speed =" + rig.velocity);
    }

    public void ResetBall()
    {
        Invoke("ActualResetBall", 2);
    }

    private void ActualResetBall()
    {
        transform.position = new Vector2(resetPosition.x, resetPosition.y);
        Start();
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }
}