using System.Collections.Generic;
using UnityEngine;

public class ChunkSpawner : MonoBehaviour
{
    [SerializeField]
    private int startingChunks = 15;
    private GameObject chunkPrefab;

    [SerializeField]
    private int ChunkLength = 30;

    public List<GameObject> chunks = new List<GameObject>();

    void Start()
    {
        LoadChunks(startingChunks);
    }

    public void LoadChunks(int chunksLoaded)
    {
        chunkPrefab = (GameObject)Resources.Load("Chunk");

        for (int i = 0; i < chunksLoaded; i++)
        {
            GameObject obj = Instantiate(
                chunkPrefab,
                new Vector3(0, 0, chunks.Count * -ChunkLength),
                Quaternion.identity
            );

            obj.GetComponent<Chunk>().chunkLength = ChunkLength;

            chunks.Add(obj);
        }
    }
}
