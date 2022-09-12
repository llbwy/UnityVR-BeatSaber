using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Emitter : MonoBehaviour
{
    public GameObject cube;
    public GameObject[] emitter;
    public Material[] cubeMaterials;
    public float timer = 1.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Vector3 cubePosition = emitter[Random.Range(0, 4)].transform.position;
            Instantiate(cube);
            cube.transform.position = cubePosition;
            cube.GetComponent<MeshRenderer>().material = cubeMaterials[Random.Range(0, 4)];
            timer = 2.0f;
            print("1");
        }
    }
}
