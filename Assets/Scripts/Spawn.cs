using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject object1;
    public float timecreation = 2;
    public float rangecreation = 2;


    // Use this for initialization
    void Start()
    {

        InvokeRepeating("creation", 0.0f, timecreation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void creation()
    {
        Vector3 spawnpoint = new Vector3(0, 0, 0);
        spawnpoint = this.transform.position + Random.onUnitSphere * rangecreation;
        spawnpoint = new Vector3(spawnpoint.x, spawnpoint.y, 0);

        GameObject objectintc = Instantiate(object1, spawnpoint, Quaternion.identity);

    }
}
