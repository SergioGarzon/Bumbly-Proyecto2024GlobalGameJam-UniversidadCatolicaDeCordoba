using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTime : MonoBehaviour
{
    public float timeStart;
    public float timeEnd;

    public string nameScene;

    public GameObject objetoScena;
    private ChangeQuitScene changeScene;


    public void Start()
    {
        changeScene = objetoScena.GetComponent<ChangeQuitScene>();
    }


    private void Update()
    {
        timeStart += Time.deltaTime;

        if (timeStart >= timeEnd)
        {
            changeScene.OpenScene(nameScene);
        }
    }
}