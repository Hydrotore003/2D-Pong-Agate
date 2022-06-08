using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rig;
    

    private void Start()
    {
        float randX = Random.Range(3f, 10f);
        float randY = Random.Range(0f, 10f);

        if (randX > 5)
        {
            randY = Random.Range(0f, 5f);
        }
        else if (randX < 5)
        {
            randY = Random.Range(5f, 10f);
        }

        speed = new Vector2(randX, randY);
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    private void Update()
    {
        
    }
}