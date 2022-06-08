using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlecontrol : MonoBehaviour
{
    //declare
    public int speed;
    public KeyCode goUP;
    public KeyCode goDOWN;
    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    { 
        //translated movement
        MoveObject(GetInput());
    }
    //private class input
    private Vector2 GetInput()
    {
        //get input
        if (Input.GetKey(goUP))
        {
            //then up
            return Vector2.up * speed;
        }
        else if (Input.GetKey(goDOWN))
        {
            //then down
            return Vector2.down * speed;
        }
        //back to zero
        return Vector2.zero;
    }
    //private class movement translate
    private void MoveObject(Vector2 movement)
    {
        //move
        rig.velocity = movement;
    }
}
