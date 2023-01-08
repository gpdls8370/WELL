using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayer : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody2D rb;
    Animator ani;

    float max;
    float up, down, right, left = 0;
    
    private void Awake()
    {
        ani = GetComponent<Animator>();
    }
    
    void JSmove()
    {
        transform.Translate(Vector2.up * variableJoystick.Vertical * speed * Time.fixedDeltaTime);
        transform.Translate(Vector2.right * variableJoystick.Horizontal * speed * Time.fixedDeltaTime);
    }
  
    void AniUpdate()
    {
        ani.speed = 0.5f;

        if (variableJoystick.Vertical > 0)
            up = variableJoystick.Vertical;
        if (variableJoystick.Vertical < 0)
            down = Math.Abs(variableJoystick.Vertical);
        if (variableJoystick.Horizontal > 0)
            right = variableJoystick.Horizontal;
        if (variableJoystick.Horizontal < 0)
            left = Math.Abs(variableJoystick.Horizontal);

        max = Math.Max(up, down);
        max = Math.Max(max, right);
        max = Math.Max(max, left);

        if (variableJoystick.Horizontal == 0 && variableJoystick.Vertical == 0)
        {
            ani.speed = 0;
        }

        if (max == up && max != 0)
            ani.SetBool("isFrontMoving", true);
        else
            ani.SetBool("isFrontMoving", false);

        if (max == down && max != 0)
            ani.SetBool("isBackMoving", true);
        else
            ani.SetBool("isBackMoving", false);

        if (max == right && max != 0)
            ani.SetBool("isRightMoving", true);
        else
            ani.SetBool("isRightMoving", false);

        if (max == left && max != 0)
            ani.SetBool("isLeftMoving", true);
        else
            ani.SetBool("isLeftMoving", false);

        
    }

    private void Update()
    {
        AniUpdate();
    }

    public void FixedUpdate()
    {
        JSmove();
    }
}