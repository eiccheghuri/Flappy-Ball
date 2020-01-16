using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField]
    private float max_Y;

    [SerializeField]
    private float spawnTime;
    [SerializeField]
    private GameObject pipe;

    public void Start()
    {
        StartSpawningPipes();
    }

    public void StartSpawningPipes()
    {
        InvokeRepeating("SpawnPipe", 0.2f,spawnTime);
    }


    public void StopSpawningPipes()
    {
        CancelInvoke("SpawnPipe");
    }

    public void SpawnPipe()
    {
        float random_value=Random.Range(-max_Y,max_Y);
        Vector3 temp_pos = new Vector3(transform.position.x,random_value,0);

        Instantiate(pipe,temp_pos,Quaternion.identity);
    }


}// pipe spawner class
