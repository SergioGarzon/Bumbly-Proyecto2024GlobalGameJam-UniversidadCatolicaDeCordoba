using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource audioChoqueBurbuja;
    public AudioSource audioJellyfish;
    public AudioSource audioFish;
    public AudioSource audioOctopus;

    public void StopAudio(int value)
    {
        if (value == 2)
        {
            audioJellyfish.Stop();
        }

        if (value == 3)
        {
            audioFish.Stop();
        }

        if (value == 4)
        {
            audioOctopus.Stop();
        }
    }

    public void PlayAudio(int value)
    {
        if(value == 1)
        {
            audioChoqueBurbuja.Play();
        }

        if(value == 2) 
        {
            audioJellyfish.Play();
        }

        if(value == 3)
        {
            audioFish.Play();
        }

        if (value == 4)
        {
            audioOctopus.Play();
        }
    }

    public void volumeBurbuja1()
    {
    }

    public void volumeBurbuja2()
    {
    }

    public void volumeBurbuja3()
    {
    }

    public void volumeBurbuja4()
    {
    }

    public void volumeBurbuja5()
    {
    }

    public void volumeBurbuja6()
    {
    }

    public void volumeBurbuja7()
    {
    }

    public void volumeBurbuja8()
    {
    }

    public void volumeBurbuja9()
    {
    }


}
