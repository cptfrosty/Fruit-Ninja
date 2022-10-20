using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;

    private void Start()
    {
        GameManager.ScoreChangeHandler += OnUpdateScore;
        OnUpdateScore();
    }

    private void OnUpdateScore()
    {
        _score.text = "Score: " + GameManager.Score;
    }
}
