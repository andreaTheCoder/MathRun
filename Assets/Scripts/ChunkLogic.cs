using UnityEngine;

public class Chunk : MonoBehaviour
{
    // Chunk length when it instantiates
    // Chunkspawner sets this value when it is spawned
    public float chunkLength = 30;

    [SerializeField]
    private float moveSpeed = 3f;

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
        // floor.localScale = new Vector3(10f, 1f, chunkLength);

        // Move floor by moveSpeed

        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

    }

    // Delete chunks once out of view
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
