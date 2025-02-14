using UnityEngine;

public class AudiosStartScene : MonoBehaviour
{
    public AudioSource[] audios;

    public AudioVolume audioVolume;

    public void PlayAudio(int valor)
    {
        if (audios[valor] != null)
        {
            audios[valor].volume = (float) audioVolume.volumeLevel;
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
