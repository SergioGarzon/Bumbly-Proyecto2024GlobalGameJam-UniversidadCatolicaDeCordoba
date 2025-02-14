using UnityEngine;

public class AudiosStartScene : MonoBehaviour
{
    public AudioSource[] audios;

    public void PlayAudio(int valor)
    {
        if (audios[valor] != null)
        {
            audios[valor].Play();
        }
    }

    public void AudioStop(int valor)
    {
        if (audios[valor] != null)
        {
            audios[valor].Stop();
        }
    }
}
