using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public float ChunkSpeed;
    public float ChunkLength = 15f;

    private Transform floor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        // Find the "Floor" object in the parent and assign it to the 'floor' variable
        floor = transform.Find("Floor");

        if (floor != null)
        {
            // Set the scale of the floor based on ChunkLength
            floor.localScale = new Vector3(10f, 1f, ChunkLength);
        }
        else
        {
        Debug.LogWarning("Floor object not found in parent.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        floor.localScale = new Vector3(10f, 1f, ChunkLength);

    }
}
