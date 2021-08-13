using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public GameObject rock;
    public GameObject ground;
    public GameObject quote;
    public GameObject quote2;
    public string[] camus;
    public AudioClip[] clips;
    [SerializeField]
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("push", 2.6f, 2.6f);
        //InvokeRepeating("spawn", 0f, 19.53318422f);
       
        
        for (int i = 0; i < camus.Length; i++)
        {
            int rnd = Random.Range(0, camus.Length);
            string tempGO = camus[rnd];
            camus[rnd] = camus[i];
            camus[i] = tempGO;
            AudioClip tempClip = clips[rnd];
            clips[rnd] = clips[i];
            clips[i] = tempClip;
        }
       

    }

    void push()
    {
        transform.position += transform.forward * 1.464175f;
        //Time.timeScale += .05f;
        
    }

    //void spawn()
    //{
    //    Debug.Log(transform.position.z);
    //}

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Mathf.Round(((Time.timeSinceLevelLoad - 9.76659f) / 19.53318f)));
        //Debug.Log(Mathf.Round(((Time.timeSinceLevelLoad - 9.76659f) % 19.53318f) * 10) / 10);

        if (index < ((Time.timeSinceLevelLoad) / 19.53318422))
        {


            GameObject[] rocks = new GameObject[3];


            rocks[0] = Instantiate(rock, new Vector3(0, 160.9982f, Mathf.Round(transform.GetChild(0).transform.position.z / 11) * 11) + transform.forward * 22 + transform.right * -1 * 3.5f, Quaternion.Euler(10.2215128f, Random.Range(-180f, 180f), 59.465137f));
            rocks[1] = Instantiate(rock, new Vector3(0, 160.9982f, Mathf.Round(transform.GetChild(0).transform.position.z / 11) * 11) + transform.forward * 22 + transform.right * 0 * 3.5f, Quaternion.Euler(10.2215128f, Random.Range(-180f, 180f), 59.465137f));
            rocks[2] = Instantiate(rock, new Vector3(0, 160.9982f, Mathf.Round(transform.GetChild(0).transform.position.z / 11) * 11) + transform.forward * 22 + transform.right * 1 * 3.5f, Quaternion.Euler(10.2215128f, Random.Range(-180f, 180f), 59.465137f));
            Destroy(rocks[Random.Range(0, 3)]);

            Instantiate(ground, new Vector3(0, 160.6766f, Mathf.Round(transform.GetChild(0).transform.position.z / 11) * 11) + transform.forward * 22, Quaternion.identity);
            if(index % 2 == 0)
            {
                GameObject q = Instantiate(quote, new Vector3(0, 160.6766f, Mathf.Round(transform.GetChild(0).transform.position.z / 11) * 11) + transform.forward * 22, Quaternion.identity);
                q.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = camus[index % camus.Length];
                if (q.GetComponent<AudioSource>())
                {
                    q.GetComponent<AudioSource>().clip = clips[index % camus.Length];

                }
                index++;
            }
            else
            {
                GameObject q = Instantiate(quote2, new Vector3(0, 160.6766f, Mathf.Round(transform.GetChild(0).transform.position.z / 11) * 11) + transform.forward * 22, Quaternion.identity);
                q.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = camus[index % camus.Length];
                if(q.GetComponent<AudioSource>())
                {
                    q.GetComponent<AudioSource>().clip = clips[index % camus.Length];

                }
                index++;
            }
            

        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 1.5f)
        {
            
            transform.position += transform.right * 3;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -1.5f)
        {

            transform.position -= transform.right * 3;
        }
    }

    
}
