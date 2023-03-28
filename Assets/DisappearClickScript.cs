using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearClickScript : MonoBehaviour
{

    GameObject game_objer;

    // Start is called before the first frame update
    void Start()
    {
        GameObject game_objer = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        game_objer.SetActive(false);
    }
}
