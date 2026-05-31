using UnityEngine;
using UnityEngine.UI;

public class AudioButtonVisual : MonoBehaviour
{
    public bool isMusicButton;

    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Start()
    {
        UpdateVisual();
    }

    public void ToggleAudio()
    {
        if(isMusicButton)
        {
            AudioManager.Instance.ToggleMusic();
        }
        else
        {
            AudioManager.Instance.ToggleSFX();
        }

        UpdateVisual();
    }

    private void UpdateVisual()
    {
        bool enabled = isMusicButton
            ? AudioManager.Instance.musicEnabled
            : AudioManager.Instance.sfxEnabled;

        Color color = _image.color;
        color.a = enabled ? 1f : 0.5f;
        _image.color = color;
    }
}