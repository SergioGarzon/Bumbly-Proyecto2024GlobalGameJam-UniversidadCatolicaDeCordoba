using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{
    public Button[] btnAudios;

    public AudioVolume audioVolume;

    public void OnClickValue(int value)
    {
        switch(value)
        {
            case 0:
                btnAudios[0].enabled = false;
                btnAudios[1].enabled = true;
                btnAudios[2].enabled = true;
                btnAudios[3].enabled = true;

                ChangeVisibilityButton(0, 0.2f);
                ChangeVisibilityButton(1, 1);
                ChangeVisibilityButton(2, 1);
                ChangeVisibilityButton(3, 1);

                audioVolume.volumeLevel = 0;
                break;
            case 1:
                btnAudios[0].enabled = true;
                btnAudios[1].enabled = false;
                btnAudios[2].enabled = true;
                btnAudios[3].enabled = true;

                ChangeVisibilityButton(0, 1);
                ChangeVisibilityButton(1, 0.2f);
                ChangeVisibilityButton(2, 1);
                ChangeVisibilityButton(3, 1);

                audioVolume.volumeLevel = 0.3;
                break;
            case 2:
                btnAudios[0].enabled = true;
                btnAudios[1].enabled = true;
                btnAudios[2].enabled = false;
                btnAudios[3].enabled = true;

                ChangeVisibilityButton(0, 1);
                ChangeVisibilityButton(1, 1);
                ChangeVisibilityButton(2, 0.2f);
                ChangeVisibilityButton(3, 1);

                audioVolume.volumeLevel = 0.6;
                break;
            case 3:
                btnAudios[0].enabled = true;
                btnAudios[1].enabled = true;
                btnAudios[2].enabled = true;
                btnAudios[3].enabled = false;

                ChangeVisibilityButton(0, 1);
                ChangeVisibilityButton(1, 1);
                ChangeVisibilityButton(2, 1);
                ChangeVisibilityButton(3, 0.2f);

                audioVolume.volumeLevel = 1;
                break;
        }        
    }

    private void ChangeVisibilityButton(int value, float tono)
    {
        Image buttonImage = btnAudios[value].GetComponent<Image>();
        Color buttonColor = buttonImage.color;
        buttonColor.a = tono;
        buttonImage.color = buttonColor;
    }

}
