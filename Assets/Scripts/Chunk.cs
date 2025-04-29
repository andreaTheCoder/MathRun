using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public float ChunkSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, ChunkSpeed*Time.deltaTime);
    }
}
