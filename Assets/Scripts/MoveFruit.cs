using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFruit : MoveObject
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cut")
        {
            GameManager.Score++;
            Destroy(this.gameObject);
        }
    }
}
