using UnityEngine;

public class PlayAwakeAudios : MonoBehaviour
{

    public AudioSource audios;
    public AudioSource audio2;
    public AudioSource audio3;

    public AudioVolume audioVolume;

    void Awake()
    {
        if (audios != null)
        {
            audios.volume = (float)audioVolume.volumeLevel;
            audios.Play();
        }

        if (audio2 != null)
        {
            audio2.volume = (float)audioVolume.volumeLevel;
            audio2.Play();
        }

        if (audio3 != null)
        {
            audio3.volume = (float)audioVolume.volumeLevel;
            audio3.Play();
        }
    }

    public void PlayAgain()
    {
        if (audios != null)
        {
            audios.volume = (float)audioVolume.volumeLevel;
            audios.Play();
        }

        if (audio2 != null)
        {
            audio2.volume = (float)audioVolume.volumeLevel;
            audio2.Play();
        }

        if (audio3 != null)
        {
            audio3.volume = (float)audioVolume.volumeLevel;
            audio3.Play();
        }
    }
}
