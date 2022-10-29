using System;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static event Action ScoreChangeHandler;
    public static event Action EndGameHandler;
    public static StatusGame CurrentStateGame;
    public static int Score
    {
        set { 
            _score = value;
            ScoreChangeHandler?.Invoke();
        }

        get
        {
            return _score;
        }
    }
    private static int _score = 0;

    private void Awake()
    {
        _score = 0;
        CurrentStateGame = StatusGame.Play;
    }

    public static void EndGame()
    {
        CurrentStateGame = StatusGame.EndGame;
        EndGameHandler?.Invoke();
    }

    public enum StatusGame
    {
        Play,
        Pause,
        EndGame
    }
}
