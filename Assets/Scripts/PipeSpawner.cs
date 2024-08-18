using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject __pipeObject;
    public float __spawnRate = 2;
    private float __timer = 0;
    public float __heightOffset = 3;

    private void SpawnPipe()
    {
        float low = transform.position.y - __heightOffset,high=transform.position.y+__heightOffset;
        Instantiate(__pipeObject, new Vector3(transform.position.x,Random.Range(low,high),0), transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(__timer<__spawnRate)
        {
            __timer += Time.deltaTime;
        }else
        {
            __timer = 0;
            SpawnPipe();
        }
    }
}
