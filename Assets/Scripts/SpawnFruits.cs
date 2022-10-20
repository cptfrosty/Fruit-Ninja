using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    [SerializeField] private GameObject prefabFruit;
    [SerializeField] private float spawnInterval;
    [SerializeField] private float _minFruitX;
    [SerializeField] private float _maxFruitX;
    [SerializeField] private float _fruitY;

    [SerializeField]
    private Sprite[] objectSprites;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("spawnObject", this.spawnInterval, this.spawnInterval);
    }
    private void spawnObject()
    {
        GameObject newObject = Instantiate(this.prefabFruit);
        newObject.transform.position = new Vector2(Random.Range(this._minFruitX, this._maxFruitX), this._fruitY);
        Sprite objectSprite = objectSprites[Random.Range(0, this.objectSprites.Length)];
        newObject.GetComponent<SpriteRenderer>().sprite = objectSprite;
    }
}
