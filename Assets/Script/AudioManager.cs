using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio Clip ----------")]
    public AudioClip background;
    public AudioClip wordTyping;
    

    //when game start play bgm
    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip, float typingSoundSpeed)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}

