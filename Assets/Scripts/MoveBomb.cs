using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBomb : MoveObject
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cut")
        {
            GameManager.EndGame();
            Destroy(this.gameObject);
        }
    }
}
