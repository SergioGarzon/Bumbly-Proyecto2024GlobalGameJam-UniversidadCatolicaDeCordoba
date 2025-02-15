using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{
    public Button[] btnAudios;

    public AudioVolume audioVolume;

    public void Awake()
    {
        switch(audioVolume.volumeLevel)
        {
            case 0:
                VisibilityButton1();
                break;
            case 0.3:
                VisibilityButton2();
                break;
            case 0.6:
                VisibilityButton3();
                break;
            case 1:
                VisibilityButton4();
                break;
        }
    }

    public void OnClickValue(int value)
    {
        switch(value)
        {
            case 0:
                VisibilityButton1();
                audioVolume.volumeLevel = 0;
                break;
            case 1:

                VisibilityButton2();
                audioVolume.volumeLevel = 0.3;
                break;
            case 2:
                VisibilityButton3();
                audioVolume.volumeLevel = 0.6;
                break;
            case 3:
                VisibilityButton4();
                audioVolume.volumeLevel = 1;
                break;
        }        
    }

    private void VisibilityButton1()
    {
        btnAudios[0].enabled = false;
        btnAudios[1].enabled = true;
        btnAudios[2].enabled = true;
        btnAudios[3].enabled = true;

        ChangeVisibilityButton(0, 0.2f);
        ChangeVisibilityButton(1, 1);
        ChangeVisibilityButton(2, 1);
        ChangeVisibilityButton(3, 1);
    }

    private void VisibilityButton2()
    {
        btnAudios[0].enabled = true;
        btnAudios[1].enabled = false;
        btnAudios[2].enabled = true;
        btnAudios[3].enabled = true;

        ChangeVisibilityButton(0, 1);
        ChangeVisibilityButton(1, 0.2f);
        ChangeVisibilityButton(2, 1);
        ChangeVisibilityButton(3, 1);
    }

    private void VisibilityButton3()
    {
        btnAudios[0].enabled = true;
        btnAudios[1].enabled = true;
        btnAudios[2].enabled = false;
        btnAudios[3].enabled = true;

        ChangeVisibilityButton(0, 1);
        ChangeVisibilityButton(1, 1);
        ChangeVisibilityButton(2, 0.2f);
        ChangeVisibilityButton(3, 1);
    }

    private void VisibilityButton4()
    {
        btnAudios[0].enabled = true;
        btnAudios[1].enabled = true;
        btnAudios[2].enabled = true;
        btnAudios[3].enabled = false;

        ChangeVisibilityButton(0, 1);
        ChangeVisibilityButton(1, 1);
        ChangeVisibilityButton(2, 1);
        ChangeVisibilityButton(3, 0.2f);
    }

    private void ChangeVisibilityButton(int value, float tono)
    {
        Image buttonImage = btnAudios[value].GetComponent<Image>();
        Color buttonColor = buttonImage.color;
        buttonColor.a = tono;
        buttonImage.color = buttonColor;
    }

}
