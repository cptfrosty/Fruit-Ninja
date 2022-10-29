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
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (true)
        {
            if (GameManager.CurrentStateGame == GameManager.StatusGame.Play)
            {
                GameObject newObject = Instantiate(this.prefabFruit);
                newObject.transform.position = new Vector2(Random.Range(this._minFruitX, this._maxFruitX), this._fruitY);
                Sprite objectSprite = objectSprites[Random.Range(0, this.objectSprites.Length)];
                newObject.GetComponent<SpriteRenderer>().sprite = objectSprite;

                yield return new WaitForSeconds(spawnInterval);
            }
            else if (GameManager.CurrentStateGame == GameManager.StatusGame.EndGame)
            {
                yield return null;
            }
        }
    }
}
