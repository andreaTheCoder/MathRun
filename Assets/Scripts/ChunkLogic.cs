using UnityEngine;

public class Chunk : MonoBehaviour
{
    // Chunk length when it instantiates
    // Chunkspawner sets this value when it is spawned
    public float chunkLength = 45;

    [SerializeField]
    private const float moveSpeed = 20f;

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
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        if (transform.position.z > chunkLength)
        {
            ChunkSpawner chunkSpawner = GameObject
                .Find("Chunk Spawner")
                .GetComponent<ChunkSpawner>();
            chunkSpawner.chunks.Remove(gameObject);

            chunkSpawner.LoadChunks(1);

            Destroy(gameObject);
        }
    }
}
