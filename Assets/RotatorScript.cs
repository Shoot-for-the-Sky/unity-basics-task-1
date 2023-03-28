using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    [SerializeField] float x_axis = 0f;
    [SerializeField] float y_axis = 0f;
    [SerializeField] float z_axis = 100f;

    private float time;

    // Update is called once per frame
    void Update()
    {
        float delta_time = Time.deltaTime;
        time += delta_time;
        transform.rotation = Quaternion.Euler(new Vector3(x_axis * time, y_axis * time, z_axis * time));
    }
}
