using UnityEngine;
using System.Collections;

public enum ePlayer
{
    Blue,
    Red
}

public class Player : MonoBehaviour {

    

    public float speed = 15f;
    public ePlayer player;

	void Start () {
	
	}
	
	void FixedUpdate() {
        float inputSpeed = 0f;
        if (player == ePlayer.Blue)
        {
            inputSpeed = Input.GetAxisRaw("Player1");
        }
        else if (player == ePlayer.Red)
        {
            inputSpeed = Input.GetAxisRaw("Player2");
        }

        transform.position += new Vector3(0f, 0f, inputSpeed * speed);
	}
}
