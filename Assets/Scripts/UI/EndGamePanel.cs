using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGamePanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private Button _reloadGame;

    private void OnEnable()
    {
        _score.text = "";
        _score.text += "Your score: " + GameManager.Score;
        _reloadGame.onClick.AddListener(OnReloadGame);
    }

    private void OnReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
