using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeQuitScene : MonoBehaviour
{

    public void OpenScene(string name_scene)
    {
        SceneManager.LoadScene(name_scene);
    }
    

    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
