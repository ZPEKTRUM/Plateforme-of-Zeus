using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int _currentScore;
    [SerializeField] TextMeshProUGUI _textToUpdate;

    public static ScoreManager instance;
    private void Awake()
    {
        instance = this;
    }

    public void AddScore(int amount)
    {
        _currentScore += amount;
        _textToUpdate.text = _currentScore.ToString();
    }


}
