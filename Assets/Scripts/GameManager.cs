using System;
using UnityEngine;
using UnityEngine.Events;

public class GameManager
{
    public static event Action ScoreChangeHandler;
    public static int Score
    {
        set { 
            ScoreChangeHandler?.Invoke();
            _score = value;
        }

        get
        {
            return _score;
        }
    }
    private static int _score;
}
