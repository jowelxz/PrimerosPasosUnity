using UnityEngine;
using UnityEngine.Audio;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instancia;

    private AudioSource audioSource;
    private bool musicaMuteada = false;

    void Awake()
    {
        if (instancia != null && instancia != this)
        {
            Destroy(gameObject);
            return;
        }

        instancia = this;
        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
    }

    public void PausarMusica()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }

    public void ReanudarMusica()
    {
        audioSource.UnPause();

        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void ReiniciarMusica()
    {
        audioSource.Stop();
        audioSource.Play();
    }

    public void DetenerMusica()
    {
        audioSource.Stop();
    }

    public void AlternarMute()
    {
        musicaMuteada = !musicaMuteada;
        audioSource.mute = musicaMuteada;
    }
}