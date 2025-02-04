using UnityEngine;

public class OpenPanel : MonoBehaviour
{

    public GameObject panel1;
    public GameObject panel2;

    public void ChangePanel()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
       
    }


    public void revertChangePanel()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        
    }

    public void pauseGame()
    {
        Time.timeScale = 0f;
    }

    public void resumeGame()
    {
        Time.timeScale = 1f;
    }

}
