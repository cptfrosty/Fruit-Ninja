using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private float minXSpeed;
    [SerializeField] private float maxXSpeed;
    [SerializeField] private float minYSpeed;
    [SerializeField] private float maxYSpeed;

    [SerializeField] private float destroyTime;

    void Start()
    {
        Vector2 speed = new Vector2(Random.Range(minXSpeed, maxXSpeed), Random.Range(minYSpeed, maxYSpeed));
        this.gameObject.GetComponent<Rigidbody2D>().velocity = speed;
        Destroy(this.gameObject, this.destroyTime);
    }
}
