using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    public GameObject[] destroyObjects;

    public void destroyObject()
    {
        for (int i = 0; i < destroyObjects.Length; i++)
        {
            Destroy(destroyObjects[i]);
        }        
    }
    


}
