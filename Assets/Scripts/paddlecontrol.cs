using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlecontrol : MonoBehaviour
{
    //declare
    public float speed;
    public float normalspeed;
    public KeyCode goUP;
    public KeyCode goDOWN;
    private Rigidbody2D rig;
    public Vector3 originalsize;
    public Vector3 scale;


    private void Start()
    {
        originalsize = transform.localScale;
        
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
        //Debug.Log("Speed =" + rig.velocity);
    }

    public void ActivatePaddleSpeed(float magnitude) 
    {
        speed *= magnitude;
        Invoke("ReturnPaddleSpeed", 5);
    }

    public void ReturnPaddleSpeed()
    {
        speed = normalspeed;
    }

    public void ActivatePaddleSize(float magnitude)
    {
        Vector3 scale = transform.localScale;
        transform.localScale = new Vector3(scale.x, scale.y * magnitude, scale.z);
        Invoke("ReturnPaddleSize", 5);
    }

    public void ActivatePaddleSize2(float magnitude)
    {
        Vector3 scale = transform.localScale;
        transform.localScale = new Vector3(scale.x, scale.y * magnitude, scale.z);
        Invoke("ReturnPaddleSize", 5);
    }

    public void ReturnPaddleSize()
    {
        transform.localScale = originalsize;
    }

}
