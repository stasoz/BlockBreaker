using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour
{

    private void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
    }

    private void Update()
    {
        if (GameManager.GameIsNotOver)
        {
            Vector3 DeskPosition = new Vector3(0f, this.transform.position.y, 0f);

            float mousePosX = Input.mousePosition.x / Screen.width * 32;
         //   float keyPos = Input.GetAxis("Horizontal");
            DeskPosition.x = mousePosX;
           

            DeskPosition.x = Mathf.Clamp(mousePosX, -9f, 9f);

            this.transform.position = DeskPosition;
        }
    }

}
