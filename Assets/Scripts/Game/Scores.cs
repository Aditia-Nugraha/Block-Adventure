using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class BestScoreData
{
    public int score = 0;
}

public class Scores : MonoBehaviour
{
    public SquareTextureData squareTextureData;
    public Text scoreText;

    private bool _newBestScore = false;
    private BestScoreData _bestScores = new BestScoreData();
    private int _currentScores;
    private string _bestScoreKey = "bsdat";

    public int CurrentScore => _currentScores;
    public bool IsNewBestScore => _newBestScore;

    private void Awake()
    {
        if (BinaryDataStream.Exist(_bestScoreKey))
        {
            StartCoroutine(ReadDataFile());
        }
    }

    private IEnumerator ReadDataFile()
    {
        _bestScores = BinaryDataStream.Read<BestScoreData>(_bestScoreKey);
        yield return new WaitForEndOfFrame();
        GameEvents.UpdateBestScoreBar(_currentScores, _bestScores.score);
    }

    void Start()
    {
        _currentScores = 0;
        _newBestScore = false;
        squareTextureData.SetStartColor();
        UpdateScoreText();
    }

    private void OnEnable()
    {
        GameEvents.AddScore += AddScores;
        GameEvents.GameOver += SaveBestScores;
    }

    private void OnDisable()
    {
        GameEvents.AddScore -= AddScores;
        GameEvents.GameOver -= SaveBestScores;
    }

    public void SaveBestScores(bool newBestScore)
    {
        BinaryDataStream.Save<BestScoreData>(_bestScores, _bestScoreKey);
    }

    private void AddScores(int scores)
    {
        _currentScores += scores;
        if(_currentScores > _bestScores.score)
        {
            _newBestScore = true;
            _bestScores.score = _currentScores;
            SaveBestScores(true);
        }

        UpdateSquareColor();
        GameEvents.UpdateBestScoreBar(_currentScores, _bestScores.score);
        UpdateScoreText();
    }

    private void UpdateSquareColor()
    {
        if(GameEvents.UpdateSquareColor != null && _currentScores >= squareTextureData.tresholdVal)
        {
            squareTextureData.UpdateColor(_currentScores);
            GameEvents.UpdateSquareColor(squareTextureData.currentColor);
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = _currentScores.ToString();
    }
}
