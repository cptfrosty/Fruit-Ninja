using System;
using UnityEngine;
using UnityEngine.Events;

public class GameManager
{
    public static event Action ScoreChangeHandler;
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
}
