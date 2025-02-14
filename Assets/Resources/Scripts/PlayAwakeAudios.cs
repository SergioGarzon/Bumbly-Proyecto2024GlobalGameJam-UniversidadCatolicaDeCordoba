using UnityEngine;

public class PlayAwakeAudios : MonoBehaviour
{

    public AudioSource audios;
    public AudioSource audio2;

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
    }
}
