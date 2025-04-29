using UnityEngine;

public class ChunkDeleter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Chunk Spawner: Collision Detected!");
        GameObject rootObject = other.transform.root.gameObject;
        Destroy(rootObject);
    }
}
