using UnityEngine;

public class ChunkDeleter : MonoBehaviour
{
    // Delete chunks once out of view
    void OnBecameInvisible()
    {
        Destroy(transform.root.gameObject);
    }
}
