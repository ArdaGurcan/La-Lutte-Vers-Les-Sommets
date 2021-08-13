using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockRotate : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * 36f / 2.6f * Time.deltaTime, 0, 0, Space.World);
    }
    private void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "obstacle")
        {
            SceneManager.LoadScene(0);
        }
    }
}
