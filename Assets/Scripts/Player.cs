﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public enum ePlayer
{
    Blue,
    Red
}

public class Player : NetworkBehaviour {

    

    public float speed = 0.06f;
    public float acceleration;
    public float maxspeed;
    public ePlayer player;

	void Start () {
	
	}
	
	void FixedUpdate() {
        float inputSpeed = 0f;
        if (isServer)
        {
            if (player == ePlayer.Blue)
            {
                inputSpeed = Input.GetAxisRaw("Player1");
                speed += acceleration;
                if (speed > maxspeed)
                {
                    speed = maxspeed;
                }
                if (inputSpeed == 0)
                {
                    speed = 0;
                }
            }
        }
        else if (isClient)
        {
            if (player == ePlayer.Red)
            {
                inputSpeed = Input.GetAxisRaw("Player2");
                speed += acceleration;
                if (speed > maxspeed)
                {
                    speed = maxspeed;
                }
                if (inputSpeed == 0)
                {
                    speed = 0;
                }
            }
        }

        transform.position += new Vector3(0f, 0f, inputSpeed * speed);
	}
}
