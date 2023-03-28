using UnityEngine;

public class HeartBeatScript : MonoBehaviour
{
    [SerializeField] float growth_speed = 0.5f;
    [SerializeField] float shrink_speed = 0.3f;
    [SerializeField] float max_size = 0.3f;
    [SerializeField] float min_size = 0.1f;

    private float new_scale;

    // Start is called before the first frame update
    private void Start()
    {
        // Make the heart not to be stuck when start
        new_scale = shrink_speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        if (transform.localScale.x >= max_size)
        {
            new_scale = -growth_speed * Time.deltaTime;
        }
        else if (transform.localScale.x <= min_size)
        {
            new_scale = shrink_speed * Time.deltaTime;
        }
        Debug.Log("new_scale: " + new_scale.ToString());
        transform.localScale += new Vector3(new_scale, new_scale, new_scale);
    }
}
