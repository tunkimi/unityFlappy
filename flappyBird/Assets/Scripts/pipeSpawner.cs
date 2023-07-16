using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{

    private float maxTime = 1.0f;
    private float timer = 0;
    public GameObject pipe;
    public float height;



    // Start is called before the first frame update
    void Start()
    {
        var jsonFromFile = File.ReadAllText(Settings.path);
        SetData a = JsonConvert.DeserializeObject<SetData>(jsonFromFile);
        Settings.LoadData(a);
        maxTime = Settings.PipeTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = GameObject.Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime; 
    }
}
