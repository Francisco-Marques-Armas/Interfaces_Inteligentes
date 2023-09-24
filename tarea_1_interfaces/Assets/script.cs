using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // PRINT ALL NEW OBJECTS ADDED FOR THE ASSIGNMENT
        GameObject[] bushes = GameObject.FindGameObjectsWithTag("Bush");
        Debug.Log("Number of objects with the tag 'bush': " + bushes.Length);
        GameObject[] terrains = GameObject.FindGameObjectsWithTag("Terrain");
        Debug.Log("Number of objects with the tag 'terrain': " + terrains.Length);
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");
        Debug.Log("Number of objects with the tag 'cube': " + cubes.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
