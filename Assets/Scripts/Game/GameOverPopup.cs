using UnityEngine;
using UnityEngine.UI;

public class GameOverPopup : MonoBehaviour
{
    public GameObject gameOverPopup;
    public GameObject losePopup;
    public GameObject newBestScorePopup;

    public Scores scores;
    public Text finalScoreText;

    void Start()
    {
        gameOverPopup.SetActive(false);
    }

    private void OnEnable()
    {
        GameEvents.GameOver += onGameOver;
    }

    private void OnDisable()
    {
        GameEvents.GameOver -= onGameOver;
    }

    private void onGameOver(bool newBestScore)
    {
        gameOverPopup.SetActive(true);
        AudioManager.Instance.StopMusic();
        AudioManager.Instance.PlaySFX(AudioManager.Instance.gameOverSfx);
        finalScoreText.text = scores.CurrentScore.ToString();
        losePopup.SetActive(!newBestScore);
        newBestScorePopup.SetActive(newBestScore);
    }
}
