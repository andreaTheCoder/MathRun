using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public float ChunkSpeed;

    // Chunk length when it instantiates
    // Chunkspawner sets this value when it is spawned
    public float chunkLength = 15;

    private Transform floor;

    void Start()
    {
        // Find the "Floor" object in the parent and assign it to the 'floor' variable
        floor = transform.Find("Floor");

        if (floor != null)
        {
            // Set the scale of the floor based on ChunkLength
            floor.localScale = new Vector3(10f, 1f, chunkLength);
        }
        else
        {
            Debug.LogWarning("Floor object not found in parent.");
        }
    }
    void Update()
    {
        Debug.Log("FLOOR" + floor.name);
        floor.localScale = new Vector3(10f, 1f, chunkLength);

    }
}
