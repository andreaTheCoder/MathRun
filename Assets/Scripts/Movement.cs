using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float RunnerSpeed = 4;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        float x = 0;
        float z = 0;

        // Left and Right movement
        if (Input.GetKey(KeyCode.LeftArrow))
            x += RunnerSpeed;
        else if (Input.GetKey(KeyCode.RightArrow))
            x -= RunnerSpeed;

        // Up and Down movement
        if (Input.GetKey(KeyCode.UpArrow))
            z -= RunnerSpeed;
        else if (Input.GetKey(KeyCode.DownArrow))
            z += RunnerSpeed;

        // Move the object in the x and y directions
        transform.position += new Vector3(x * Time.deltaTime, 0, z * Time.deltaTime);
    }
}