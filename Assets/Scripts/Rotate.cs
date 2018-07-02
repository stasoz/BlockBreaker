using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float speed = 100f;
    private void Update()
    {
        if (GameManager.GameIsNotOver)
        {
            transform.Rotate(0f, 0f, speed * Time.deltaTime);
        }
    }
}
