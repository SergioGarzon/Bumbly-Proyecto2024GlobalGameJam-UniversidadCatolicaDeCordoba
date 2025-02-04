using Unity.VisualScripting;
using UnityEngine;

public class LoadResources : MonoBehaviour
{
    public GameObject fish;
    public GameObject bobble_collection;
    public GameObject bobble_collection1;
    public GameObject bobble_collection2;
    public GameObject bobble_collection3;
    public GameObject bobble_collection4;
    public GameObject bobble_collection5;
    public GameObject bobble_collection6;
    public GameObject bobble_collection7;
    public GameObject octopus_sprite;
    public GameObject jellyfish1;
    public GameObject jellyfish2;
    public GameObject jellyfish3;
    public GameObject gameObjectAudioJellyfish;
    public GameObject turtle;
   
    public GameObject gameObjectOctopus;

    public GameObject gameObjectAudioTurtle;


    void Start()
    {
        Instantiate(fish, new Vector3(29.3f, 20.17f, 6.46f), Quaternion.identity);
        Instantiate(bobble_collection, new Vector3(-21.97f, 12.81f, 0.14480f), Quaternion.identity);
        Instantiate(bobble_collection1, new Vector3(-1.6f, 18.53f, 0.1448038f), Quaternion.identity);
        Instantiate(bobble_collection1, new Vector3(-10.04f, 6.15f, 0.14480f), Quaternion.identity);
        Instantiate(bobble_collection3, new Vector3(24.27f, 16.96f, 0.1448038f), Quaternion.identity);
        Instantiate(bobble_collection4, new Vector3(24.27f, -9.65f, 0.1448038f), Quaternion.identity);
        Instantiate(bobble_collection5, new Vector3(-15.54f, -6.9f, 0.1448038f), Quaternion.identity);
        Instantiate(bobble_collection6, new Vector3(19.75f, -1.52f, 0.1448038f), Quaternion.identity);
        Instantiate(bobble_collection7, new Vector3(2.01f, 5.78f, 0.1448038f), Quaternion.identity);
        Instantiate(octopus_sprite, new Vector3(18.6f, -7.514f, 5.7f), Quaternion.identity);
        Instantiate(jellyfish1, new Vector3(-18.38f, 16.09f, 5.91f), Quaternion.identity);
        Instantiate(jellyfish2, new Vector3(-17.8f, 21.01f, 5.91f), Quaternion.identity);
        Instantiate(jellyfish3, new Vector3(-14.32f, 18.84f, 5.91f), Quaternion.identity);
        Instantiate(gameObjectAudioJellyfish, new Vector3(-18.1f, 16.66f, 5.91f), Quaternion.identity);
        
        Instantiate(turtle, new Vector3(26.29f, 20.17f, 0f), Quaternion.identity);

       
        Instantiate(gameObjectOctopus, new Vector3(17.61635f, -8.103988f, 5.7f), Quaternion.identity);
        Instantiate(gameObjectAudioTurtle, new Vector3(26.29f, 20.17f, 0f), Quaternion.identity);


    }
}
