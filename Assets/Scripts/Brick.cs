using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;
    private int timesHit;
	void Start () {
        timesHit = 0;	
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            timesHit += 1;
            CheckOnHit();
            switch(timesHit)
            {
                case 1:
                    this.gameObject.GetComponent<Renderer>().material.color = Color.gray*(-10);
                    break;
                case 2:
                    this.gameObject.GetComponent<Renderer>().material.color = Color.gray    ;
                    break;
            }
        }
    }
    void CheckOnHit()
    {
        if (timesHit == maxHits) Destroy(this.gameObject);
    }
}
