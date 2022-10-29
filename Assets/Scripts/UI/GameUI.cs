using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private GameObject _endGamePanel;

    private void Start()
    {
        GameManager.ScoreChangeHandler += OnUpdateScore;
        GameManager.EndGameHandler += ShowEndGamePanel;

        OnUpdateScore();
        HideEndGamePanel();
    }

    private void OnUpdateScore()
    {
        _score.text = "Score: " + GameManager.Score;
    }

    private void ShowEndGamePanel() => _endGamePanel.SetActive(true);

    private void HideEndGamePanel() => _endGamePanel.SetActive(false);

    private void OnDestroy()
    {
        GameManager.ScoreChangeHandler -= OnUpdateScore;
        GameManager.EndGameHandler -= ShowEndGamePanel;
    }
}
