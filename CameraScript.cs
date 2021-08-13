using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.Magnitude(new Vector3(0, 0.7320874f / 2.6f * Time.deltaTime, 1.268013f / 2.6f * Time.deltaTime)) * Vector3.forward;
    }
}
