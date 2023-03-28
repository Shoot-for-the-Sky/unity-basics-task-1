using UnityEngine;

public class OscillatorMoverScript : MonoBehaviour
{
    // Unity field for changing oscillator movement
    [SerializeField] private float momentum = 5f;
    [SerializeField] private float rate = 1f;
    [SerializeField] private int freq = RandIntInRange(1, 3);
    [SerializeField] private Vector3 axis = Vector3.right;

    // Private field for calculating the oscillator movement
    private float speed;
    private float time;
    private Vector3 start_position;

    // Start is called before the first frame update
    private void Start()
    {
        start_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float delta_time = Time.deltaTime;
        time += delta_time;
        float location = momentum * Mathf.Sin(freq * time);
        Vector3 new_position = start_position + (axis * location);
        speed = Mathf.Lerp(speed, Mathf.Sign(location) * Mathf.Abs((rate * delta_time) - speed), delta_time);
        transform.position = new_position;
    }

    // Return random integer in range between two integers
    // Help taken from: https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp
    private static int RandIntInRange(int min, int max)
    {
        System.Random rand = new System.Random();
        return rand.Next(min, max);
    }
}
