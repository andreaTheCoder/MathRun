using UnityEngine;

public class ChunkSpawner : MonoBehaviour
{
    [SerializeField]
    private int startingChunks = 15;
    private GameObject chunkPrefab;

    [SerializeField]
    private int chunkLength = 10;

    // Start is calle
    // d once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        chunkPrefab = (GameObject)Resources.Load("Chunk");

        for (int i = 0; i < startingChunks; i++)
        {
            GameObject obj = Instantiate(
                chunkPrefab,
                new Vector3(0, 0, i * chunkLength),
                Quaternion.identity
            );

            obj.GetComponent<Chunk>().chunkLength = chunkLength;
        }

    }

    // Update is called once per frame
    void Update() { }
}
