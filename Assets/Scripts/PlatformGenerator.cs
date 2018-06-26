using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

    public GameObject platform;
    public Transform generationPoint;
    float pos = 0;

	// Use this for initialization
	void Start ()
    {
        transform.position = platform.transform.position;
        Instantiate(platform, transform.position, transform.rotation);
        CreatePlatform();
        CreatePlatform();
        CreatePlatform();
        CreatePlatform();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y < generationPoint.position.y)
        {
            CreatePlatform();
        }
    }

    void CreatePlatform()
    {
        do
        {
            pos = Random.Range(-2f, 2f);
        }
        while (Mathf.Abs(transform.position.x - pos) < 1);  
        transform.position = new Vector3(0f + pos, transform.position.y + 2f, transform.position.z);
        Instantiate(platform, transform.position, transform.rotation);
    }
}
