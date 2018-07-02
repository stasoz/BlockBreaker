using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public MovePaddle paddle;
    private Vector3 paddleToBallVector;
    private bool hasStarted = false;

	void Start ()
    {
        paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	void Update ()
    {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
            if (Input.GetMouseButton(0))
            {
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
                hasStarted = true;
            }
        }
        CheckOnEndGameForBall();
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="LoseWall")
        {
            GameManager.GameIsNotOver = false;
        }
    }
    void CheckOnEndGameForBall()
    {
        if(!GameManager.GameIsNotOver)
        {
            this.gameObject.SetActive(false);
        }
    }
}
