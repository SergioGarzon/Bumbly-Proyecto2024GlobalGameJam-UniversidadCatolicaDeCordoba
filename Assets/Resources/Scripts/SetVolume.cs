using UnityEngine;

public class SetVolume : MonoBehaviour
{
    public AudioVolume audioVolume;

    public void Awake()
    {
        audioVolume.volumeLevel = 1;
    }

}
