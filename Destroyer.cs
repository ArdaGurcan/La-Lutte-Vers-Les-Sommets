using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    PlayerScript player;
    bool played = false;
    

    // Start is called before the first frame update
    void Start()
    {
        player = Camera.main.GetComponent<CameraScript>().player.GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.index - 7 > transform.position.z /11)
        {
            Destroy(gameObject);
        }
        Debug.Log((player.index-3)+ " , " + transform.position.z / 11);
        if (player.index -3  > transform.position.z / 11 && GetComponent<AudioSource>() && !played)
        {
            played = true;
            GetComponent<AudioSource>().Play();
        }
    }
}
