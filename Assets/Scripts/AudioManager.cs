using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Music")]
    public AudioSource musicSource;
    public AudioClip bgm;

    [Header("SFX")]
    public AudioSource sfxSource;
    public AudioClip dropSfx;
    public AudioClip gameOverSfx;
    public AudioClip clearSfx;

    public bool musicEnabled = true;
    public bool sfxEnabled = true;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        musicSource.clip = bgm;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }

    public void PlayMusic()
    {
        if (!musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        if(!sfxEnabled) return;

        sfxSource.PlayOneShot(clip);
    }

    public void ToggleMusic()
    {
        musicEnabled = !musicEnabled;
        musicSource.mute = !musicEnabled;
    }

    public void ToggleSFX()
    {
        sfxEnabled = !sfxEnabled;
        sfxSource.mute = !sfxEnabled;
    }
}