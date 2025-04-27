using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] 
    private GameObject runnerReference; 
    private Runner runner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        runner = new Runner(runnerReference, 2);
    }

    // Update is called once per frame
    void Update()
    {
        runner.Move();
    }

    public class Runner
    {
        private float speed;
        private GameObject runnerObject;

        public Runner(GameObject runnerObject, float speed)
        {
            this.runnerObject = runnerObject;
            this.speed = speed;
        }

        public float Speed
        {
            get {
                return speed;
            }
            
            set {
                speed = value;
            } 
        }

        public void Move()
        {
            float x = 0;
            float z = 0;

            // Left and Right movement
            if (Input.GetKey(KeyCode.LeftArrow)) 
                x += speed;
            else if (Input.GetKey(KeyCode.RightArrow)) 
                x -= speed;

            // Up and Down movement
            if (Input.GetKey(KeyCode.UpArrow)) 
                z -= speed;
            else if (Input.GetKey(KeyCode.DownArrow))
                z += speed;

            // Move the object in the x and y directions
            runnerObject.transform.position += new Vector3(x * Time.deltaTime, 0, z * Time.deltaTime);
        }
    }
}