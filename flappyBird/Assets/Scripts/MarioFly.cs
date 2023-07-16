using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MarioFly : MonoBehaviour
{

    private float velocity = 1.0f;

    private Rigidbody2D rb;


    public GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


        var jsonFromFile = File.ReadAllText(Settings.path);
        SetData a = JsonConvert.DeserializeObject<SetData>(jsonFromFile); 
        Settings.LoadData(a);

        velocity = Settings.MarioVelocity;



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }

        rb.rotation = 2 * rb.velocity.y;

    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        gameManager.GameOver();
    }

}
