using UnityEngine;

public class CursorGame : MonoBehaviour
{
    public Texture2D textureImage;    


    void Start()
    {
        Vector2 vec = new Vector2(this.textureImage.width * 0.5f, this.textureImage.height * 0.5f);
        Cursor.SetCursor(this.textureImage, vec, CursorMode.ForceSoftware);
    }
}
